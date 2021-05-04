using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, Context>, ICategoryDal
    {
    }
}
