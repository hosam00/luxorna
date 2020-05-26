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
    public class PackageService
    {
        //
        public UnitOfWork UnitOfWork { get; set; }
        private GenericRepository<Package> packageRepo;
        public PackageService(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            packageRepo = unitOfWork.PackageRepo;
        }
        public PackageEditViewModel Add(PackageEditViewModel package)
        {
            Package _package = packageRepo.Add(package.toModel());
            UnitOfWork.commit();
            return _package.toEditViewModel();
        }
        public PackageEditViewModel Update(PackageEditViewModel package)
        {
            Package _package = packageRepo.Add(package.toModel());
            UnitOfWork.commit();
            return _package.toEditViewModel();
        }
        public PackageViewModel GetByID(int id)
        {
            Package _package = packageRepo.GetByID(id);
            return _package.toViewModel();
        }

        public IEnumerable<PackageViewModel> GetAll()
        {

            return packageRepo.GetAll().ToList().Select(i => i.toViewModel());
        }
        public IEnumerable<PackageViewModel> GetFilter(string name)
        {
            var packages = packageRepo.GetFilter(a => a.Name == name);
            return packages.ToList().Select(i => i.toViewModel());
        }

        public void Remove(PackageEditViewModel admin)
        {
            packageRepo.Remove(admin.toModel());
            UnitOfWork.commit();
        }
    }
}
