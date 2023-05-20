using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            //Console.WriteLine(productManager.GetById(5));

            //foreach (var products in productManager.GetProductDetails())
            //{
            //    Console.WriteLine(products.ProductName+" / "+products.CategoryName);
            //}

            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var products in result.Data)
                {
                    Console.WriteLine(products.ProductName + " / " + products.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
