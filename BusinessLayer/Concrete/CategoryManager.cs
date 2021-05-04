using Business.Abstract;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            if (   category.CategoryName == "" 
                || category.CategoryName.Length <= 3
                || category.CategoryDescription == "" 
                || category.CategoryName.Length >= 51
                )
            {
                return new ErrorResult();
            }
            else
            {
                _categoryDal.Add(category);
                return new SuccessResult();
            }            
        }

        public IDataResult<List<Category>> GetAll()
        {            
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

    }
}
