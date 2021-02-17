using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstrack;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
public    class EfProductDal:EfEntityRepositoryBase<Product,NortwindContext>,IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NortwindContext context=new NortwindContext())
            {
                var result = from p in context.Products
                    join c in context.Categories
                        on p.CategoryId equals c.CategoryId
                    select new ProductDetailDto
                    {
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName,
                        ProductId = p.ProductId,
                        UnitInStok = p.UnitsInStock
                    };

                return result.ToList();

            }
        }
    }
}
