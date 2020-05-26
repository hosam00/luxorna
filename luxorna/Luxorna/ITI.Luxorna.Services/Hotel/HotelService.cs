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
    public class HotelService
    {
        public UnitOfWork unitOfWork { get; set; }
        private GenericRepository<Hotel> HotelRepo;
        public HotelService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            HotelRepo = unitOfWork.HotelRepo;
        }
        public HotelEditViewModel Add(HotelEditViewModel Hotel)
        {
            Hotel _Hotel = HotelRepo.Add(Hotel.toModel());
            unitOfWork.commit();
            return _Hotel.toEditViewModel();
        }
        public HotelEditViewModel Update(HotelEditViewModel Hotel)
        {
            Hotel _Hotel = HotelRepo.Update(Hotel.toModel());
            unitOfWork.commit();
            return _Hotel.toEditViewModel();
        }

        public HotelViewModel GetByID(int id)
        {
            Hotel Hotel = HotelRepo.GetByID(id);
            return Hotel.toViewModel();
        }

        public IEnumerable<HotelViewModel> GetAll()
        {

            return HotelRepo.GetAll().ToList().Select(i => i.toViewModel());
        }
        public IEnumerable<HotelViewModel> GetFilter(string Name)
        {
            var Departments = HotelRepo.GetFilter(a => a.Name == Name);
            return Departments.ToList().Select(i => i.toViewModel());
        }

        public void Remove(HotelEditViewModel Hotel)
        {
            HotelRepo.Remove(Hotel.toModel());
            unitOfWork.commit();
        }

    }
}
