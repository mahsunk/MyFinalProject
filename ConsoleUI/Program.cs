using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        //SOLİD
        //Open Close Principle
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
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var pruct in result.Data)
                {
                    Console.WriteLine(pruct.ProductName + " / " + pruct.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

             
        }
    }


}
