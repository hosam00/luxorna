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
    public class HotelController : ApiController
    {
        private readonly HotelService HotelService;
        public HotelController(HotelService service)
        {
            HotelService = service;
        }
        [HttpGet]
        public IEnumerable<HotelViewModel> AllHotels()
        {
            return HotelService.GetAll();
        }
        [HttpGet]
        public HotelViewModel GetHotelByID(int id)
        {
            return HotelService.GetByID(id);
        }
        [HttpGet]
        public IEnumerable<HotelViewModel> FilterHotel(String Name)
        {
            return HotelService.GetFilter(Name);
        }
        [HttpPost]
        public HotelEditViewModel AddHotel(HotelEditViewModel HotelEditView)
        {
            var Hotel = HotelService.Add(HotelEditView);
            return Hotel;
        }
        [HttpPost]
        public HotelEditViewModel EditHotel(HotelEditViewModel HotelEditView)
        {
            var Hotel = HotelService.Update(HotelEditView);
            return Hotel;
        }
        [HttpDelete]
        public void RemoveHotel(int id)
        {

            HotelService.Remove(new HotelEditViewModel() { ID = id });

        }



    }
}