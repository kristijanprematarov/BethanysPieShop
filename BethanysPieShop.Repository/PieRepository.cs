using BethanysPieShop.Data;
using BethanysPieShop.Entities;
using BethanysPieShop.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BethanysPieShop.Repository
{
    public class PieRepository : IPieRepository
    {
        private readonly DataContext _dataContext;

        public PieRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _dataContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _dataContext.Pies.Include(c => c.Category).Where(pie => pie.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return _dataContext.Pies.FirstOrDefault(pie => pie.PieId == pieId);
        }
    }
}
