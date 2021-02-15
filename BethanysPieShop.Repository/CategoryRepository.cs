using BethanysPieShop.Data;
using BethanysPieShop.Entities;
using BethanysPieShop.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShop.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _dataContext;

        public CategoryRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public IEnumerable<Category> AllCategories 
        {
            get
            {
                return _dataContext.Categories;
            }
        }
    }
}
