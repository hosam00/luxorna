using ITI.Luxorna.Services;
using ITI.Luxorna.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ITI.Luxorna.Presentation
{
    public class UserController : ApiController
    {
        private readonly UserService UserService;
        public UserController(UserService service)
        {
            UserService = service;
        }
        [HttpGet]
        public IEnumerable<UserViewModel> AllUsers()
        {
            return UserService.GetAll();
        }
        [HttpGet]
        public UserViewModel GetUserByID(int id)
        {
            return UserService.GetByID(id);
        }
        [HttpGet]
        public IEnumerable<UserViewModel> FilterUser(String Name)
        {
            return UserService.GetFilter(Name);
        }
        [HttpPost]
        public UserEditViewModel AddUser(UserEditViewModel UserEditView)
        {
            var User = UserService.Add(UserEditView);
            return User;
        }
        [HttpPost]
        public UserEditViewModel EditUser(UserEditViewModel UserEditView)
        {
            var User = UserService.Update(UserEditView);
            return User;
        }
        [HttpDelete]
        public void RemoveUser(int id)
        {

            UserService.Remove(new UserEditViewModel() { ID = id });

        }
    }
}
