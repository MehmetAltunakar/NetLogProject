using EFCoreNetlogProject.Entity.Model;
using NetlogProject.Business.Abstract;
using NetlogProject.Entity.Request;
using NetlogProject.Entity.Response;
using NetlogProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetlogProject.Business.Concrete
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepo _userRepo;
        public UserBusiness(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public ResponseViewModel Add(UserRequest userRequest)
        {
            var response = new ResponseViewModel();

            var user = new User()
            {
                firstName = userRequest.firstName,
                lastName = userRequest.lastName,
                phoneNumber = userRequest.phoneNumber,
                address = userRequest.address,
                createDate = DateTime.UtcNow,
                createdBy = userRequest.createdBy,
                profilePicture = userRequest.profilepicture
            };

            _userRepo.Add(user);
            var saving = _userRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = "Id : " + user.id;
            return response;
        }

        public ResponseViewModel Delete(int id)
        {
            var response = new ResponseViewModel();

            var user = _userRepo.Get(p => p.id == id && !p.isDeleted);

            if (user == null)
            {
                response.IsSuccess = false;
                response.Message = "User bulunamadı.";
                return response;
            }

            user.isDeleted = true;

            _userRepo.Update(user);
            var saving = _userRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = user;
            return response;
        }

        public ResponseViewModel Get(int id)
        {
            var response = new ResponseViewModel();

            response.Data = _userRepo.Get(p => p.id == id && !p.isDeleted);

            return response;
        }
        public ResponseViewModel List()
        {
            var response = new ResponseViewModel();

            response.Data = _userRepo.List(p => !p.isDeleted).ToList();

            return response;
        }

        public ResponseViewModel Update(UserRequest userRequest)
        {
            var response = new ResponseViewModel();
            
            var user = new User()
            {
                id = userRequest.id,
                firstName = userRequest.firstName,
                lastName = userRequest.lastName,
                phoneNumber = userRequest.phoneNumber,
                address = userRequest.address,
                modifyDate = DateTime.UtcNow,
                modifiedBy = userRequest.modifiedBy,
                profilePicture = userRequest.profilepicture
            };

            _userRepo.Update(user);
            var saving = _userRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            return response;
        }
    }
}
