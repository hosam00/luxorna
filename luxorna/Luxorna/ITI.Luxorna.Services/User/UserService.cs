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
    public class UserService
    {
        public UnitOfWork unitOfWork { get; set; }
        private GenericRepository<User> UserRepo;
        public UserService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            UserRepo = unitOfWork.UserRepo;
        }
        public UserEditViewModel Add(UserEditViewModel User)
        {
            User _User = UserRepo.Add(User.toModel());
            unitOfWork.commit();
            return _User.toEditViewModel();
        }
        public UserEditViewModel Update(UserEditViewModel User)
        {
            User _User = UserRepo.Update(User.toModel());
            unitOfWork.commit();
            return _User.toEditViewModel();
        }
        public UserViewModel GetByID(int id)
        {
            User User = UserRepo.GetByID(id);
            return User.toViewModel();
        }

        public IEnumerable<UserViewModel> GetAll()
        {

            return UserRepo.GetAll().ToList().Select(i => i.toViewModel());
        }
        public IEnumerable<UserViewModel> GetFilter(string UserName)
        {
            var Departments = UserRepo.GetFilter(a => a.UserName == UserName);
            return Departments.ToList().Select(i => i.toViewModel());
        }

        public void Remove(UserEditViewModel User)
        {
            UserRepo.Remove(User.toModel());
            unitOfWork.commit();
        }
    }
}
