using EFTask_2.Context;
using EFTask_2.Model;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace EFTask_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product firstProduct = new Product(){ Name = "T_shirt", Price = 12};
            Product secondProduct = new Product() { Name = "Socks", Price = 2 };
            Product thirdProduct = new Product() { Name = "Shoes", Price = 30 };
            Order firstOrder = new Order() { Address = "Nablus" };
            Order SecondOrder = new Order() { Address = "Jenin" };
            Order ThirdOrder = new Order() { Address = "Jericho" };
            ApplicationDbContext Context = new ApplicationDbContext();
            Context.Products.Add(firstProduct);
            Context.Products.Add(secondProduct);
            Context.Products.Add(thirdProduct);
            Context.Orders.Add(firstOrder);
            Context.Orders.Add(SecondOrder);
            Context.Orders.Add(ThirdOrder);
            Context.SaveChanges();
            var Productss = Context.Products.ToList();
            var Orderss = Context.Orders.ToList();
            var firstProductUpdate = Context.Products.First();
            firstProductUpdate.Name = "Dress";
            var firstOrderUpdate = Context.Orders.First();
            firstOrderUpdate.CreatedAt = new DateTime(2012,10,10,10,0,0);
            var P1 = Context.Products.First(pro => pro.Id == 2);
            var O1 = Context.Orders.First(Ord => Ord.Id == 3);
            Context.Products.Remove(P1);
            Context.Orders.Remove(O1);
            Context.SaveChanges();





        }
    }
}
