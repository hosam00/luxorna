using ITI.Luxorna.Entities;
using ITI.Luxorna.Repositories;
using ITI.Luxorna.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.Services
{
   public class ResturantMenuItemService
    {

        public UnitOfWork UnitOfWork { get; set; }
        private GenericRepository<ResturantMenuItem> ResturantMenuItemRepo;
        public ResturantMenuItemService(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            ResturantMenuItemRepo = unitOfWork.ResturantMenuItemRepo;
        }
        public ResturantMenuItemEditViewModel Add(ResturantMenuItemEditViewModel _ResturantMenuItem)
        {
            ResturantMenuItem ResturantMenuItem = ResturantMenuItemRepo.Add(_ResturantMenuItem.toModel());
            UnitOfWork.commit();
            return ResturantMenuItem.toEditViewModel();
        }
        public ResturantMenuItemEditViewModel Update(ResturantMenuItemEditViewModel _ResturantMenuItem)
        {
            ResturantMenuItem ResturantMenuItem = ResturantMenuItemRepo.Add(_ResturantMenuItem.toModel());
            UnitOfWork.commit();
            return ResturantMenuItem.toEditViewModel();
        }
        public ResturantMenuItemViewModel GetByID(int id)
        {
            ResturantMenuItem _ResturantMenuItem = ResturantMenuItemRepo.GetByID(id);
            return _ResturantMenuItem.toViewModel();
        }

        public IEnumerable<ResturantMenuItemViewModel> GetAll()
        {

            return ResturantMenuItemRepo.GetAll().ToList().Select(i => i.toViewModel());
        }
        public IEnumerable<ResturantMenuItemViewModel> GetFilter(string ItemName)
        {
            var ResturantMenuItems = ResturantMenuItemRepo.GetFilter(a => a.ItemName == ItemName);
            return ResturantMenuItems.ToList().Select(i => i.toViewModel());
        }

        public void Remove(ResturantMenuItemEditViewModel resturantMenuItem)
        {
            ResturantMenuItemRepo.Remove(resturantMenuItem.toModel());
            UnitOfWork.commit();
        }
    }
}
