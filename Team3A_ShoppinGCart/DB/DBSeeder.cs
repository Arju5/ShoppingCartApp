using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppinG_Cart.Models;

namespace ShoppinG_Cart.DB
{
    public class DBSeeder
    {
        public DBSeeder(Shopping_Cart_DBContext dBcontext)
        {
            // Create users 
            User user1 = new User();
            user1.UserId = "U01";
            user1.UserName = "cherwah";
            user1.Password = "c662432d01bbebf89a778e06f5226974";
            user1.FullName = "Tan Cher Wah";
            user1.SessionId = "S001";
            user1.SessionData = "abc";
            dBcontext.Add(user1);
            dBcontext.SaveChanges();

            User user2 = new User();
            user2.UserId = "U02";
            user2.UserName = "tin";
            user2.Password = "811137414f6975fd9b48dd36b73f2fb1";
            user2.FullName = "Nguyen Tri Tin";
            user2.SessionId = "S002";
            user2.SessionData = "def";
            dBcontext.Add(user2);
            dBcontext.SaveChanges();

            User user3 = new User();
            user3.UserId = "U03";
            user3.UserName = "team3a";
            user3.Password = "986f2e65a04439f51c26f04a73d484c7";
            user3.FullName = "Team 3A - SA 50";
            user3.SessionId = "S003";
            user3.SessionData = "abc";
            dBcontext.Add(user3);
            dBcontext.SaveChanges();


            //create product type
            ProductType producttype1 = new ProductType();
            producttype1.ProductTypeId = "PT001";
            producttype1.ProductTypeName = "Development";
            dBcontext.Add(producttype1);
            dBcontext.SaveChanges();

            ProductType producttype2 = new ProductType();
            producttype2.ProductTypeId = "PT002";
            producttype2.ProductTypeName = "Designing";
            dBcontext.Add(producttype2);
            dBcontext.SaveChanges();

            ProductType producttype3 = new ProductType();
            producttype3.ProductTypeId = "PT003";
            producttype3.ProductTypeName = "Operating System";
            dBcontext.Add(producttype3);
            dBcontext.SaveChanges();

            ProductType producttype4 = new ProductType();
            producttype4.ProductTypeId = "PT004";
            producttype4.ProductTypeName = "Basic colloboration";
            dBcontext.Add(producttype4);
            dBcontext.SaveChanges();

            //create Products
            Product product1 = new Product();
            product1.ProductId = "P001";
            product1.ProductName = "Matlab";
            product1.ProductDescription = "Matlab is matrix based software";
            product1.ProductPrice = 42.25;
            product1.ImageURL = "matlab.png";
            product1.ProductTypeId = producttype1.ProductTypeId;
            dBcontext.Add(product1);
            dBcontext.SaveChanges();

            Product product2 = new Product();
            product2.ProductId = "P002";
            product2.ProductName = "MS Office";
            product2.ProductDescription = "Microsoft Office 365";
            product2.ProductPrice = 39.35;
            product2.ImageURL = "office.png";
            product2.ProductTypeId = producttype4.ProductTypeId;
            dBcontext.Add(product2);
            dBcontext.SaveChanges();

            Product product3 = new Product();
            product3.ProductId = "P003";
            product3.ProductName = "Auto Cad";
            product3.ProductDescription = "AutoCad is designing software";
            product3.ProductPrice = 49.65;
            product3.ImageURL = "autocad.png";
            product3.ProductTypeId = producttype3.ProductTypeId;
            dBcontext.Add(product3);
            dBcontext.SaveChanges();

            Product product4 = new Product();
            product4.ProductId = "P004";
            product4.ProductName = "Adobe";
            product4.ProductDescription = "Adobe AE is editing software";
            product4.ProductPrice = 29.95;
            product4.ImageURL = "adobe.png";
            product4.ProductTypeId = producttype2.ProductTypeId;
            dBcontext.Add(product4);
            dBcontext.SaveChanges();

            Product product5 = new Product();
            product5.ProductId = "P005";
            product5.ProductName = "Unity";
            product5.ProductDescription = "Unity is gaming software";
            product5.ProductPrice = 33.00;
            product5.ImageURL = "unity.png";
            product5.ProductTypeId = producttype2.ProductTypeId;
            dBcontext.Add(product5);
            dBcontext.SaveChanges();

            Product product6 = new Product();
            product6.ProductId = "P006";
            product6.ProductName = "Business Skype";
            product6.ProductDescription = "Business online calls";
            product6.ProductPrice = 33.75;
            product6.ImageURL = "skype.png";
            product6.ProductTypeId = producttype4.ProductTypeId;
            dBcontext.Add(product6);
            dBcontext.SaveChanges();

            Product product7 = new Product();
            product7.ProductId = "P007";
            product7.ProductName = "Microsoft Visual Studio";
            product7.ProductDescription = "Application Development";
            product7.ProductPrice = 56.60;
            product7.ImageURL = "visual.png";
            product7.ProductTypeId = producttype1.ProductTypeId;
            dBcontext.Add(product7);
            dBcontext.SaveChanges();

            Product product8 = new Product();
            product8.ProductId = "P008";
            product8.ProductName = "Windows 10";
            product8.ProductDescription = "Windows Operating System";
            product8.ProductPrice = 19.80;
            product8.ImageURL = "windows.png";
            product8.ProductTypeId = producttype3.ProductTypeId;
            dBcontext.Add(product8);
            dBcontext.SaveChanges();



            //Create Cart
            Cart cart1 = new Cart();
            cart1.CartId = "C001";
            cart1.ProductId = product1.ProductId;
            cart1.ProductQuantity = 1;
            cart1.UserId = user1.UserId;
            dBcontext.Add(cart1);
            dBcontext.SaveChanges();

            Cart cart2 = new Cart();
            cart2.CartId = "C001";
            cart2.ProductId = product2.ProductId;
            cart2.ProductQuantity = 1;
            cart2.UserId = user1.UserId;
            dBcontext.Add(cart2);
            dBcontext.SaveChanges();

            Cart cart3 = new Cart();
            cart3.CartId = "C002";
            cart3.ProductId = product3.ProductId;
            cart3.ProductQuantity = 2;
            cart3.UserId = user2.UserId;
            dBcontext.Add(cart3);
            dBcontext.SaveChanges();

            // Create orders 
            Order order1 = new Order();
            order1.OrderId = "O001";
            order1.OrderDate = new DateTime(2020, 4, 10);
            order1.TotalPrice = 138.00;
            order1.UserId = user1.UserId;
            dBcontext.Add(order1);
            dBcontext.SaveChanges();

            Order order2 = new Order();
            order2.OrderId = "O002";
            order2.OrderDate = new DateTime(2020, 4, 10);
            order2.TotalPrice = 98.00;
            order2.UserId = user2.UserId;
            dBcontext.Add(order2);
            dBcontext.SaveChanges();

            //Create Order Details
            OrderDetail orderdetail1 = new OrderDetail();
            orderdetail1.OrderId = order1.OrderId;
            orderdetail1.ProductId = product1.ProductId;
            orderdetail1.Quantity = 1;
            dBcontext.Add(orderdetail1);
            dBcontext.SaveChanges();

            OrderDetail orderdetail2 = new OrderDetail();
            orderdetail2.OrderId = order1.OrderId;
            orderdetail2.ProductId = product2.ProductId;
            orderdetail2.Quantity = 1;
            dBcontext.Add(orderdetail2);
            dBcontext.SaveChanges();

            OrderDetail orderdetail3 = new OrderDetail();
            orderdetail3.OrderId = order2.OrderId;
            orderdetail3.ProductId = product3.ProductId;
            orderdetail3.Quantity = 2;
            dBcontext.Add(orderdetail3);
            dBcontext.SaveChanges();

            //Create Activation code
            ActivationCode ac1 = new ActivationCode();
            ac1.OrderId = order1.OrderId;
            ac1.ProductId = product1.ProductId;
            ac1.ActivationCodeId = "AC1-001-abc-100";
            dBcontext.Add(ac1);
            dBcontext.SaveChanges();

            ActivationCode ac2 = new ActivationCode();
            ac2.OrderId = order1.OrderId;
            ac2.ProductId = product2.ProductId;
            ac2.ActivationCodeId = "AC2-002-def-200";
            dBcontext.Add(ac2);
            dBcontext.SaveChanges();

            ActivationCode ac3 = new ActivationCode();
            ac3.OrderId = order2.OrderId;
            ac3.ProductId = product3.ProductId;
            ac3.ActivationCodeId = "AC3-003-ghi-300";
            dBcontext.Add(ac3);
            dBcontext.SaveChanges();

            ActivationCode ac4 = new ActivationCode();
            ac4.OrderId = order2.OrderId;
            ac4.ProductId = product3.ProductId;
            ac4.ActivationCodeId = "AC4-004-jkl-400";
            dBcontext.Add(ac4);
            dBcontext.SaveChanges();

        }
    }
}
