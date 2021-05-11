using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
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
            _categoryDal.Add(category);
            return new SuccessResult();
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult();
        }

        public IDataResult<List<Category>> GetAll()
        {            
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);

            //return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult();
        }
    }
}
