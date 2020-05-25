using ITI.Luxorna.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.ViewModels
{
    public static class ResturantImageExtentions
    {

        public static ResturantImageViewModel toViewModel(this ResturantImage model)
        {
            return new ResturantImageViewModel()
            {
                ID = model.ID,
                Image = model.Image

            };
        }
        public static ResturantImageEditViewModel toEditViewModel(this ResturantImage model)
        {
            return new ResturantImageEditViewModel()
            {
                ID = model.ID,
                Image = model.Image


            };
        }
        public static ResturantImage toModel(this ResturantImageEditViewModel model)
        {
            return new ResturantImage()
            {
                ID = model.ID,
                Image = model.Image




            };
        }
    }
}