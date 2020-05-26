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
    public class ResturantService
    {
        public UnitOfWork UnitOfWork { get; set; }
        private GenericRepository<Resturant> ResturantRepo;
        public ResturantService(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            ResturantRepo = unitOfWork.ResturantRepo;
        }
        public ResturantEditViewModel Add(ResturantEditViewModel Resturant)
        {
            Resturant _Resturant = ResturantRepo.Add(Resturant.toModel());
            UnitOfWork.commit();
            return _Resturant.toEditViewModel();
        }
        public ResturantEditViewModel Update(ResturantEditViewModel Resturant)
        {
            Resturant _Resturant = ResturantRepo.Add(Resturant.toModel());
            UnitOfWork.commit();
            return _Resturant.toEditViewModel();
        }
        public ResturantViewModel GetByID(int id)
        {
            Resturant _Resturant = ResturantRepo.GetByID(id);
            return _Resturant.toViewModel();
        }

        public IEnumerable<ResturantViewModel> GetAll()
        {

            return ResturantRepo.GetAll().ToList().Select(i => i.toViewModel());
        }
        public IEnumerable<ResturantViewModel> GetFilter(string name)
        {
            var Resturants = ResturantRepo.GetFilter(a => a.Name == name);
            return Resturants.ToList().Select(i => i.toViewModel());
        }

        public void Remove(ResturantEditViewModel admin)
        {
            ResturantRepo.Remove(admin.toModel());
            UnitOfWork.commit();
        }
    }
}
