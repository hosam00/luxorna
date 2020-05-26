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
    public class ResturantMenuItemController : ApiController
    {
        private readonly ResturantMenuItemService resturantMenuItemService;
        public ResturantMenuItemController(ResturantMenuItemService _resturantMenuItemService)
        {
            resturantMenuItemService = _resturantMenuItemService;
        }
        [HttpGet]
        public IEnumerable<ResturantMenuItemViewModel> AllResturantMenuItems()
        {
            return resturantMenuItemService.GetAll();
        }
        [HttpGet]
        public ResturantMenuItemViewModel GetResturantMenuItemByID(int id)
        {
            return resturantMenuItemService.GetByID(id);
        }
        [HttpGet]
        public IEnumerable<ResturantMenuItemViewModel> FilterResturantMenuItem(string itemName)
        {
            return resturantMenuItemService.GetFilter(itemName);
        }
        [HttpPost]
        public ResturantMenuItemEditViewModel AddResturantMenuItem(ResturantMenuItemEditViewModel ResturantMenuItemEditView)
        {
            var ResturantMenuItem = resturantMenuItemService.Add(ResturantMenuItemEditView);
            return ResturantMenuItem;
        }
        public ResturantMenuItemEditViewModel EditResturantMenuItem(ResturantMenuItemEditViewModel ResturantMenuItemEditView)
        {
            var ResturantMenuItem = resturantMenuItemService.Update(ResturantMenuItemEditView);
            return ResturantMenuItem;
        }
        [HttpDelete]
        public void RemoveResturantMenuItem(int id)
        {

            resturantMenuItemService.Remove(new ResturantMenuItemEditViewModel() { ID = id });

        }
    }
}
