using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfOrderDal:EfEntityRepositoryBase<Order,NortwindContext>,IOrderDal
    {
    }
}
