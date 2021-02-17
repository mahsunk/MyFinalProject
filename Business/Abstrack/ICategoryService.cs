﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstrack
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}
