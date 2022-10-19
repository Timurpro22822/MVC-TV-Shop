using Data.Models;

namespace MVC_TV_Shop.ViewModels
{
    public class TVCardViewModel
    {
        public TVModel TVModel { get; set; }
        public bool IsInCart { get; set; }
    }
}
