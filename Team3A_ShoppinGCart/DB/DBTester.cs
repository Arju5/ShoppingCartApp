using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppinG_Cart.DB;
using ShoppinG_Cart.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ShoppinG_Cart.DB
{
    public class DBTester
    {
        private readonly Shopping_Cart_DBContext db;

        public DBTester(Shopping_Cart_DBContext db)
        {
            this.db = db;
        }

        public List<Product> Run()
        {
            List<Product> products = db.Products.ToList();
            return products;
        }

        public List<Product> Find(string SearchString)
        {
            List<Product> products = db.Products.Where(model => model.ProductDescription.Contains(SearchString)).ToList();
            return products;
        }

        public Product FindProduct(string productId)
        {
            Product product = (Product)db.Products.Where(model => model.ProductId == productId).FirstOrDefault();
            if (product != null)
                return product;
            else
                return null;
        }
        //public List<Cart_Model> CartItems()
        //{
        //    List<Cart_Model> listofCartItems = (from c in db.Carts
        //                                        join prod in db.Products
        //                                        on c.ProductId equals prod.ProductId
        //                                        join prodtype in db.ProductTypes
        //                                        on prod.ProductTypeId equals prodtype.ProductTypeId
        //                                        where c.UserId == "U01"
        //                                        select new Cart_Model()
        //                                        {
        //                                            CartId = c.CartId,
        //                                            ProductId = c.ProductId,
        //                                            ProductQuantity = c.ProductQuantity,
        //                                            ProductName = prod.ProductName,
        //                                            ProductDescription = prod.ProductDescription,
        //                                            ProductPrice = prod.ProductPrice,
        //                                            ImageURL = prod.ImageURL,
        //                                            ProductTypeName = prodtype.ProductTypeName,
        //                                            subTotal = prod.ProductPrice * c.ProductQuantity
        //                                        }).ToList();
        //    return listofCartItems;
        //}
        //public string DeleteItems(string productId)
        //{
        //    Cart cart = db.Carts
        //                .Where(x => x.ProductId == productId
        //                )
        //                .FirstOrDefault(); 
            
        //    if (cart == null)
        //    { return "fail"; }
            
        //    db.Carts.Remove(cart);
        //    db.SaveChanges();
                    
        //    return "success";
        //}

        public string AddtoOrder(string TotalAmt, string userId, List<UserCart> selectedproducts)
        {
            //need to get logged in userid
            // var userId = "U02";
            //List<Cart> cart = db.Carts.Where(x => x.UserId == ).ToList(); 
            
                //add to order from cart
                Order order = new Order()
                {
                    OrderId = Guid.NewGuid().ToString(),
                    UserId = userId,
                    OrderDate = DateTime.UtcNow,
                    TotalPrice = Double.Parse(TotalAmt)
                };
                db.Orders.Add(order);
                db.SaveChanges();
                foreach (var item in selectedproducts)
                {
                    //add to order details from cart
                    OrderDetail orderDetail = new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        ProductId = item.ProductId,
                        Quantity = item.ProductQuantity
                    };
                    db.OrderDetails.Add(orderDetail);
                    db.SaveChanges();

                    //Create activation code
                    for (int i = 0; i < item.ProductQuantity; i++)
                    {
                        ActivationCode activationCode = new ActivationCode()
                        {
                            OrderId = order.OrderId,
                            ProductId = item.ProductId,
                            ActivationCodeId = Guid.NewGuid().ToString()
                        };
                        db.ActivationCodes.Add(activationCode);
                        db.SaveChanges();
                    }
                    //Remove from cart
                    //db.Remove(item);
                    //db.SaveChanges();
                }

                //db.Remove(cart);
                //db.SaveChanges();
                return "success";
        }

        public void updateCart(UserCart cart)
        {
            //Cart_Model cart_Model = new Cart_Model()
            //{
            //    ProductQuantity = cart.ProductQuantity,
            //    subTotal = cart.subTotal
            //};
            Cart c = db.Carts.Where(x => x.ProductId == cart.ProductId ).FirstOrDefault();
            c.ProductId = cart.ProductId;
            c.ProductQuantity = cart.ProductQuantity;
            c.CartId = c.CartId;
            c.UserId = c.UserId;
            db.Carts.Update(c);
            db.SaveChanges();
        }

    }

}
