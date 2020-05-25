using ITI.Luxorna.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.ViewModels
{
   public static class SizeExtentions
    {

        public static SizeViewModel toViewModel(this Size model)
        {
            return new SizeViewModel()
            {
                ID = model.ID,
                ItemSize = model.ItemSize
                
            };
        }
        public static SizeEditViewModel toEditViewModel(this Size model)
        {
            return new SizeEditViewModel()
            {
                ID = model.ID,
                ItemSize = model.ItemSize
            };
        }
        public static Size toModel(this SizeEditViewModel model)
        {
            return new Size()
            {
                ID = model.ID,
                ItemSize = model.ItemSize


            };
        }
    }
}