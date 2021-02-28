using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstrack
{
   public interface ICategoryService
    {
      IDataResult< List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);
    }
}
