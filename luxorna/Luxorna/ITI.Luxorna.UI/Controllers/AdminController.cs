using ITI.Luxorna.Services;
using ITI.Luxorna.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ITI.Luxorna.UI
{
    public class AdminController:ApiController
    {
        private readonly AdminService adminService;
        public AdminController (AdminService service)
        {
            adminService = service;
        }
        [HttpGet]
        public IEnumerable<AdminViewModel>AllAdmins()
        {
            return adminService.GetAll();
        }
        [HttpGet]
        public AdminViewModel GetAdminByID( int id )
        {
            return adminService.GetByID(id);
        }
        [HttpGet]
        public IEnumerable<AdminViewModel> FilterAdmin(String Name)
        {
            return adminService.GetFilter(Name);
        }
        [HttpPost]
        public AdminEditViewModel AddAdmin(AdminEditViewModel adminEditView)
        {
            var admin = adminService.Add(adminEditView);
            return admin;
        }
        [HttpPost]
        public AdminEditViewModel EditAdmin(AdminEditViewModel adminEditView)
        {
            var admin = adminService.Update(adminEditView);
            return admin;
        }
        [HttpDelete]
        public void RemoveAdmin(int id)
        {

            adminService.Remove(new AdminEditViewModel() { ID = id });

        }



    }
}