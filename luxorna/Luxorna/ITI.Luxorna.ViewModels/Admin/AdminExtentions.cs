using ITI.Luxorna.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.ViewModels
{
    public static class AdminExtentions
    {
        public static AdminViewModel toViewModel(this Admin model)
        {
            return new AdminViewModel()
            {
                ID = model.ID,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName,
                Password = model.Password,
                CreatedBy = model.admin.FirstName + "  " + model.admin.LastName,
                UpdatedBy = model.admin.FirstName + "  " + model.admin.LastName,
                Image=model.Image

            };

             
        }
        public static AdminEditViewModel toEditViewModel(this Admin editmodel)
        {
            return new AdminEditViewModel()
            {
                ID = editmodel.ID,
                FirstName = editmodel.FirstName,
                LastName = editmodel.LastName,
                Email = editmodel.Email,
                UserName = editmodel.UserName,
                Password = editmodel.Password,
                CreatedBy = editmodel.admin.FirstName + "  " + editmodel.admin.LastName,
                UpdatedBy = editmodel.admin.FirstName + "  " + editmodel.admin.LastName,
                // create id and name 
                CreateBy=editmodel.AdminID.GetValueOrDefault(),
                UpdateBy=editmodel.AdminID.GetValueOrDefault(),
                CreateDate=editmodel.CreateDate,
                UpdateDate=editmodel.UpdateDate,
                Image=editmodel.Image
            };
        }
        public static Admin toModel(this AdminEditViewModel model)
        {
            return new Admin()
            {
                ID=model.ID,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName,
                Password = model.Password,
                Image = model.Image,
                CreateBy=model.CreateBy,
                UpdateBy=model.UpdateBy



            };
        }
    }
}
