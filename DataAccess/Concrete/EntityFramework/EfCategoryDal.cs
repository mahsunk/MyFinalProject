using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
public    class EfCategoryDal: EfEntityRepositoryBase<Category, NortwindContext>, ICategoryDal
    {
        
    }
}
