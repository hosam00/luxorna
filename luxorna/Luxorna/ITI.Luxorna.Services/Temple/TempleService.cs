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
    public class TempleService
    {
        public UnitOfWork unitOfWork { get; set; }
        private GenericRepository<Temple> TempleRepo;
        public TempleService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            TempleRepo = unitOfWork.TempleRepo;
        }
        public TempleEditViewModel Add(TempleEditViewModel Temple)
        {
            Temple _Temple = TempleRepo.Add(Temple.toModel());
            unitOfWork.commit();
            return _Temple.toEditViewModel();
        }
        public TempleEditViewModel Update(TempleEditViewModel Temple)
        {
            Temple _Temple = TempleRepo.Update(Temple.toModel());
            unitOfWork.commit();
            return _Temple.toEditViewModel();
        }
        public TempleViewModel GetByID(int id)
        {
            Temple Temple = TempleRepo.GetByID(id);
            return Temple.toViewModel();
        }

        public IEnumerable<TempleViewModel> GetAll()
        {

            return TempleRepo.GetAll().ToList().Select(i => i.toViewModel());
        }
        public IEnumerable<TempleViewModel> GetFilter(string Name)
        {
            var Departments = TempleRepo.GetFilter(a => a.Name == Name);
            return Departments.ToList().Select(i => i.toViewModel());
        }

        public void Remove(TempleEditViewModel Temple)
        {
            TempleRepo.Remove(Temple.toModel());
            unitOfWork.commit();
        }
    }
}
