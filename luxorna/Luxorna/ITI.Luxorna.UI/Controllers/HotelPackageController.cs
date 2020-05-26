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
    public class HotelPackageController : ApiController
    {
        private readonly HotelPackageService HotelPackageService;
        public HotelPackageController(HotelPackageService service)
        {
            HotelPackageService = service;
        }
        [HttpGet]
        public IEnumerable<HotelPackageViewModel> AllHotelPackages()
        {
            return HotelPackageService.GetAll();
        }
        [HttpGet]
        public HotelPackageViewModel GetHotelPackageByID(int id)
        {
            return HotelPackageService.GetByID(id);
        }
        [HttpGet]
        public IEnumerable<HotelPackageViewModel> FilterHotelPackage(String Name)
        {
            return HotelPackageService.GetFilter(Name);
        }
        [HttpPost]
        public HotelPackageEditViewModel AddHotelPackage(HotelPackageEditViewModel HotelPackageEditView)
        {
            var HotelPackage = HotelPackageService.Add(HotelPackageEditView);
            return HotelPackage;
        }
        [HttpPost]
        public HotelPackageEditViewModel EditHotelPackage(HotelPackageEditViewModel HotelPackageEditView)
        {
            var HotelPackage = HotelPackageService.Update(HotelPackageEditView);
            return HotelPackage;
        }
        [HttpDelete]
        public void RemoveHotelPackage(int id)
        {

            HotelPackageService.Remove(new HotelPackageEditViewModel() { ID = id });

        }



    }
}
    

