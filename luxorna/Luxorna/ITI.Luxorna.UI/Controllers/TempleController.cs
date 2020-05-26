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
    public class TempleController : ApiController
    {
        private readonly TempleService TempleService;
        public TempleController(TempleService service)
        {
            TempleService = service;
        }
        [HttpGet]
        public IEnumerable<TempleViewModel> AllTemples()
        {
            return TempleService.GetAll();
        }
        [HttpGet]
        public TempleViewModel GetTempleByID(int id)
        {
            return TempleService.GetByID(id);
        }
        [HttpGet]
        public IEnumerable<TempleViewModel> FilterTemple(String Name)
        {
            return TempleService.GetFilter(Name);
        }
        [HttpPost]
        public TempleEditViewModel AddTemple(TempleEditViewModel TempleEditView)
        {
            var Temple = TempleService.Add(TempleEditView);
            return Temple;
        }
        [HttpPost]
        public TempleEditViewModel EditTemple(TempleEditViewModel TempleEditView)
        {
            var Temple = TempleService.Update(TempleEditView);
            return Temple;
        }
        [HttpDelete]
        public void RemoveTemple(int id)
        {

            TempleService.Remove(new TempleEditViewModel() { ID = id });

        }
    }
}
