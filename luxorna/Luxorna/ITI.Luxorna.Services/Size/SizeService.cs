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
    public class SizeService
    {
        public UnitOfWork unitOfWork { get; set; }
        private GenericRepository<Size> SizeRepo;
        public SizeService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            SizeRepo = unitOfWork.SizeRepo;
        }
        public SizeEditViewModel Add(SizeEditViewModel Size)
        {
            Size _Size = SizeRepo.Add(Size.toModel());
            unitOfWork.commit();
            return _Size.toEditViewModel();
        }
        public SizeEditViewModel Update(SizeEditViewModel Size)
        {
            Size _Size = SizeRepo.Update(Size.toModel());
            unitOfWork.commit();
            return _Size.toEditViewModel();
        }
        public SizeViewModel GetByID(int id)
        {
            Size Size = SizeRepo.GetByID(id);
            return Size.toViewModel();
        }

        public IEnumerable<SizeViewModel> GetAll()
        {

            return SizeRepo.GetAll().ToList().Select(i => i.toViewModel());
        }
        public IEnumerable<SizeViewModel> GetFilter(string size)
        {
            var Departments = SizeRepo.GetFilter(a => a.ItemSize == size);
            return Departments.ToList().Select(i => i.toViewModel());
        }

        public void Remove(SizeEditViewModel Size)
        {
            SizeRepo.Remove(Size.toModel());
            unitOfWork.commit();
        }
    }
}
