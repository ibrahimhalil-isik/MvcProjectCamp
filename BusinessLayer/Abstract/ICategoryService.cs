using Core.Utilities.Results.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        //IDataResult<Category> GetById(int categoryId);
        Category GetById(int categoryId);
        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);

    }
}