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
    public class ResturantController : ApiController
    {
        private readonly ResturantService resturantService;
        public ResturantController(ResturantService _resturantService)
        {
            resturantService = _resturantService;
        }
        [HttpGet]
        public IEnumerable<ResturantViewModel> AllResturants()
        {
            return resturantService.GetAll();
        }
        [HttpGet]
        public ResturantViewModel GetResturantByID(int id)
        {
            return resturantService.GetByID(id);
        }
        [HttpGet]
        public IEnumerable<ResturantViewModel> FilterResturant(String Name)
        {
            return resturantService.GetFilter(Name);
        }
        [HttpPost]
        public ResturantEditViewModel AddResturant(ResturantEditViewModel ResturantEditView)
        {
            var Resturant = resturantService.Add(ResturantEditView);
            return Resturant;
        }
        public ResturantEditViewModel EditResturant(ResturantEditViewModel ResturantEditView)
        {
            var Resturant = resturantService.Update(ResturantEditView);
            return Resturant;
        }
        [HttpDelete]
        public void RemoveResturant(int id)
        {

            resturantService.Remove(new ResturantEditViewModel() { ID = id });

        }
    }
}
