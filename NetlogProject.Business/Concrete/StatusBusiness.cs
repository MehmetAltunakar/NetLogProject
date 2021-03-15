using EFCoreNetlogProject.Entity.Model;
using NetlogProject.Business.Abstract;
using NetlogProject.Entity.Request;
using NetlogProject.Entity.Response;
using NetlogProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Business.Concrete
{
    public class StatusBusiness : IStatusBusiness
    {
        private readonly IStatusRepo _statusRepo;
        public StatusBusiness(IStatusRepo statusRepo)
        {
            _statusRepo = statusRepo;
        }
        public ResponseViewModel Add(StatusRequest statusRequest)
        {
            var response = new ResponseViewModel();

            var status = new Status()
            {
                id = statusRequest.id,
                name = statusRequest.name,
                createDate = DateTime.UtcNow,
                createdBy = statusRequest.createdBy
                
            };

            _statusRepo.Add(status);
            var saving = _statusRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = "Id : " + status.id;
            return response;
        }

        public ResponseViewModel Delete(int id)
        {
            var response = new ResponseViewModel();

            var status = _statusRepo.Get(p => p.id == id && !p.isDeleted);

            if (status == null)
            {
                response.IsSuccess = false;
                response.Message = "status bulunamadı.";
                return response;
            }

            status.isDeleted = true;

            _statusRepo.Update(status);
            var saving = _statusRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = status;
            return response;
        }

        public ResponseViewModel Get(int id)
        {
            var response = new ResponseViewModel();

            response.Data = _statusRepo.Get(p => p.id == id && !p.isDeleted);

            return response;
        }

        public ResponseViewModel Update(StatusRequest statusRequest)
        {
            var response = new ResponseViewModel();
            
            var status = new Status()
            {
                id = statusRequest.id,
                name = statusRequest.name,
                createdBy = statusRequest.createdBy,
               
                modifyDate = DateTime.UtcNow,
                modifiedBy = statusRequest.modifiedBy
              
            };

            _statusRepo.Update(status);
            var saving = _statusRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            return response;
        }

    }
}
