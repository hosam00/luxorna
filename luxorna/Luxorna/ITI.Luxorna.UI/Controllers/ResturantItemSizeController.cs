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
    public class ResturantItemSizeController : ApiController
    {
        private readonly ResturantItemSizeService resturantItemSizeService;
        public ResturantItemSizeController(ResturantItemSizeService _resturantItemSizeService)
        {
            resturantItemSizeService = _resturantItemSizeService;
        }
        [HttpGet]
        public IEnumerable<ResturantItemSizeViewModel> AllResturantItemSizes()
        {
            return resturantItemSizeService.GetAll();
        }
        [HttpGet]
        public ResturantItemSizeViewModel GetResturantItemSizeByID(int id)
        {
            return resturantItemSizeService.GetByID(id);
        }
        [HttpGet]
        public IEnumerable<ResturantItemSizeViewModel> FilterResturantItemSize(int id)
        {
            return resturantItemSizeService.GetFilter(id);
        }
        [HttpPost]
        public ResturantItemSizeEditViewModel AddResturantItemSize(ResturantItemSizeEditViewModel ResturantItemSizeEditView)
        {
            var ResturantItemSize = resturantItemSizeService.Add(ResturantItemSizeEditView);
            return ResturantItemSize;
        }
        public ResturantItemSizeEditViewModel EditResturantItemSize(ResturantItemSizeEditViewModel ResturantItemSizeEditView)
        {
            var ResturantItemSize = resturantItemSizeService.Update(ResturantItemSizeEditView);
            return ResturantItemSize;
        }
        [HttpDelete]
        public void RemoveResturantItemSize(int id)
        {

            resturantItemSizeService.Remove(new ResturantItemSizeEditViewModel() { ID = id });

        }
    }
}
