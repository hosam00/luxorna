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
    public class PackageController : ApiController
    {
        private readonly PackageService packageService;
        public PackageController(PackageService _packageService)
        {
           packageService = _packageService;
        }
        [HttpGet]
        public IEnumerable<PackageViewModel> AllPackages()
        {
            return packageService.GetAll();
        }
        [HttpGet]
        public PackageViewModel GetPackageByID(int id)
        {
            return packageService.GetByID(id);
        }
        [HttpGet]
        public IEnumerable<PackageViewModel> FilterPackage(String Name)
        {
            return packageService.GetFilter(Name);
        }
        [HttpPost]
        public PackageEditViewModel AddPackage(PackageEditViewModel PackageEditView)
        {
            var package = packageService.Add(PackageEditView);
            return package;
        }
        public PackageEditViewModel EditPackage(PackageEditViewModel PackageEditView)
        {
            var package = packageService.Update(PackageEditView);
            return package;
        }
        [HttpDelete]
        public void RemovePackage(int id)
        {

            packageService.Remove(new PackageEditViewModel() { ID = id });

        }

    }
}
