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
    public class TemplePackageController : ApiController
    {
        private readonly TemplePackageService TemplePackageService;
        public TemplePackageController(TemplePackageService service)
        {
            TemplePackageService = service;
        }
        [HttpGet]
        public IEnumerable<TemplePackageViewModel> AllTemplePackages()
        {
            return TemplePackageService.GetAll();
        }
        [HttpGet]
        public TemplePackageViewModel GetTemplePackageByID(int id)
        {
            return TemplePackageService.GetByID(id);
        }
        [HttpGet]
        public IEnumerable<TemplePackageViewModel> FilterTemplePackage(int id)
        {
            return TemplePackageService.GetFilter(id);
        }
        [HttpPost]
        public TemplePackageEditViewModel AddTemplePackage(TemplePackageEditViewModel TemplePackageEditView)
        {
            var TemplePackage = TemplePackageService.Add(TemplePackageEditView);
            return TemplePackage;
        }
        [HttpPost]
        public TemplePackageEditViewModel EditTemplePackage(TemplePackageEditViewModel TemplePackageEditView)
        {
            var TemplePackage = TemplePackageService.Update(TemplePackageEditView);
            return TemplePackage;
        }
        [HttpDelete]
        public void RemoveTemplePackage(int id)
        {

            TemplePackageService.Remove(new TemplePackageEditViewModel() { ID = id });

        }
    }
}
