using BethanysPieShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShop.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
