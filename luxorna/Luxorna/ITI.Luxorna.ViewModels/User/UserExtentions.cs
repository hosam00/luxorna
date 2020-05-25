using ITI.Luxorna.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.ViewModels
{
     public static class UserExtentions
    {
        public static UserViewModel toViewModel(this User model)
        {
            return new UserViewModel()
            {
                ID = model.ID,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName,
                Password = model.Password,
                Phone=model.Phone,
                Image = model.Image,
                CountryName=model.Country.Name

            };


        }
        public static UserEditViewModel toEditViewModel(this User editmodel)
        {
            return new UserEditViewModel()
            {
                ID = editmodel.ID,
                FirstName = editmodel.FirstName,
                LastName = editmodel.LastName,
                Email = editmodel.Email,
                UserName = editmodel.UserName,
                Password = editmodel.Password,
                Phone=editmodel.Phone,
                CreateDate = editmodel.CreateDate,
                UpdateDate = editmodel.UpdateDate,
                Image = editmodel.Image,
                CountryName=editmodel.Country.Name,
                IsDeleted=false,
                DeleteDate=DateTime.Now

            };
        }
        public static User toModel(this UserEditViewModel model)
        {
            return new User()
            {
                ID = model.ID,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName,
                Password = model.Password,
                Image = model.Image,
                Phone=model.Phone,
                UpdateDate=model.UpdateDate,
                IsDeleted=model.IsDeleted,
                DeleteDate=model.DeleteDate,
                CreateDate=model.CreateDate,
                
                
                



            };
        }
    }
}