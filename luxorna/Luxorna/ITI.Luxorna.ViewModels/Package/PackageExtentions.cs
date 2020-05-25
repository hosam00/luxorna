using ITI.Luxorna.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.ViewModels
{
   public static class PackageExtentions
    {
        public static PackageViewModel toViewModel(this Package model)
        {
            return new PackageViewModel()
            {
                ID = model.ID,
                Name = model.Name,
                EndDate=model.EndDate,
                PersonNumber=model.PersonNumber,
                StartDate=model.StartDate,
                TotalPrice=model.TotalPrice

            };
        }
        public static PackageEditViewModel toEditViewModel(this Package model)
        {
            return new PackageEditViewModel()
            {
                ID = model.ID,
                Name = model.Name,
                EndDate = model.EndDate,
                PersonNumber = model.PersonNumber,
                StartDate = model.StartDate,
                TotalPrice = model.TotalPrice,
                UpdateDate = model.UpdateDate,
                CreateDate=model.CreateDate
                

            };
        }
        public static Package toModel(this PackageEditViewModel model)
        {
            return new Package()
            {
                ID = model.ID,
                Name = model.Name,
                CreateDate=model.CreateDate,
                TotalPrice=model.TotalPrice,
                StartDate=model.StartDate,
                UpdateDate=model.UpdateDate,
                EndDate=model.EndDate,
                PersonNumber=model.PersonNumber
                
            };
        }
    }
}