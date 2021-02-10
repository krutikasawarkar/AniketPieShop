using AniketPieShop.Models;
using System.Collections.Generic;

namespace AniketPieShop.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
