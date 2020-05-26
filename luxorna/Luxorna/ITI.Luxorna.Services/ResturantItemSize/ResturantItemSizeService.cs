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
    public class ResturantItemSizeService
    {
        //
        public UnitOfWork UnitOfWork { get; set; }
        private GenericRepository<ResturantItemSize> ResturantItemSizeRepo;
        public ResturantItemSizeService(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            ResturantItemSizeRepo = unitOfWork.ResturantItemSizeRepo;
        }
        public ResturantItemSizeEditViewModel Add(ResturantItemSizeEditViewModel _ResturantItemSize)
        {
            ResturantItemSize ResturantItemSize = ResturantItemSizeRepo.Add(_ResturantItemSize.toModel());
            UnitOfWork.commit();
            return ResturantItemSize.toEditViewModel();
        }
        public ResturantItemSizeEditViewModel Update(ResturantItemSizeEditViewModel _ResturantItemSize)
        {
            ResturantItemSize ResturantItemSize = ResturantItemSizeRepo.Add(_ResturantItemSize.toModel());
            UnitOfWork.commit();
            return ResturantItemSize.toEditViewModel();
        }
        public ResturantItemSizeViewModel GetByID(int id)
        {
            ResturantItemSize _ResturantItemSize = ResturantItemSizeRepo.GetByID(id);
            return _ResturantItemSize.toViewModel();
        }

        public IEnumerable<ResturantItemSizeViewModel> GetAll()
        {

            return ResturantItemSizeRepo.GetAll().ToList().Select(i => i.toViewModel());
        }
        public IEnumerable<ResturantItemSizeViewModel> GetFilter(int id)
        {
            var ResturantItemSizes = ResturantItemSizeRepo.GetFilter(a => a.ID== id);
            return ResturantItemSizes.ToList().Select(i => i.toViewModel());
        }

        public void Remove(ResturantItemSizeEditViewModel resturantItemSize)
        {
            ResturantItemSizeRepo.Remove(resturantItemSize.toModel());
            UnitOfWork.commit();
        }
    }
}
