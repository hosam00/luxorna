using ITI.Luxorna.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.ViewModels
{
   public static  class ResturantMenuItemExtentions
    {
        public static ResturantMenuItemViewModel toViewModel(this ResturantMenuItem model)
        {
            return new ResturantMenuItemViewModel()
            {
                ID = model.ID,
                Image = model.Image,
                ItemName=model.ItemName

            };
        }
        public static ResturantMenuItemEditViewModel toEditViewModel(this ResturantMenuItem model)
        {
            return new ResturantMenuItemEditViewModel()
            {
                ID = model.ID,
                Image = model.Image,
                ItemName = model.ItemName

            };
        }
        public static ResturantMenuItem toModel(this ResturantMenuItemEditViewModel model)
        {
            return new ResturantMenuItem()
            {
                ID = model.ID,
                Image = model.Image,
                ItemName = model.ItemName
            };
        }
    }
}