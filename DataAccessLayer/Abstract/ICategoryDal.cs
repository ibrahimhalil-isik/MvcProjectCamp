﻿using Core.DataAccess;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {

    }
}