using BethanysPieShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShop.Repository.Interfaces
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
    }
}
