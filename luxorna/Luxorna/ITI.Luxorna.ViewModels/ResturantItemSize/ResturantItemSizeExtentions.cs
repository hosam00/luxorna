using ITI.Luxorna.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.ViewModels
{
    public static class ResturantItemResturantItemSizeExtentions
    {

        public static ResturantItemSizeViewModel toViewModel(this ResturantItemSize model)
        {
            return new ResturantItemSizeViewModel()
            {
                ID = model.ID,
               Price=model.Price

            };
        }
        public static ResturantItemSizeEditViewModel toEditViewModel(this ResturantItemSize model)
        {
            return new ResturantItemSizeEditViewModel()
            {
                ID = model.ID,
               Price=model.Price

            };
        }
        public static ResturantItemSize toModel(this ResturantItemSizeEditViewModel model)
        {
            return new ResturantItemSize()
            {
                ID = model.ID,
                Price = model.Price
            };
        }
    }
}