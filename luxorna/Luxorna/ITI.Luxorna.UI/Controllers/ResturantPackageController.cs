using ITI.Luxorna.Services;
using ITI.Luxorna.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ITI.Luxorna.UI
{
    public class ResturantPackageController : ApiController
    {
        private readonly ResturantPackageService resturantPackageService;
        public ResturantPackageController(ResturantPackageService _resturantPackageService)
        {
            resturantPackageService = _resturantPackageService;
        }
        [HttpGet]
        public IEnumerable<ResturantPackageViewModel> AllResturantPackages()
        {
            return resturantPackageService.GetAll();
        }

        [HttpGet]
        public ResturantPackageViewModel GetResturantPackageByID(int id)
        {
            return resturantPackageService.GetByID(id);
        }
        [HttpGet]
        public IEnumerable<ResturantPackageViewModel> FilterResturantPackage(String Name)
        {
            return resturantPackageService.GetFilter(Name);
        }
        [HttpPost]
        public ResturantPackageEditViewModel AddResturantPackage(ResturantPackageEditViewModel ResturantPackageEditView)
        {
            var ResturantPackage = resturantPackageService.Add(ResturantPackageEditView);
            return ResturantPackage;
        }
        [HttpPost]
        public ResturantPackageEditViewModel EditResturantPackage(ResturantPackageEditViewModel ResturantPackageEditView)
        {
            var ResturantPackage = resturantPackageService.Update(ResturantPackageEditView);
            return ResturantPackage;

        }
        [HttpDelete]
        public void RemoveResturantPackage(int id)
        {

            resturantPackageService.Remove(new ResturantPackageEditViewModel() { ID = id });

        }
    }
}
