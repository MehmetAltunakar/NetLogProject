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
    public class VehicleTypeBusiness : IVehicleTypeBusiness
    {
        private readonly IVehicleTypeRepo _vehicleTypeRepo;
        public VehicleTypeBusiness(IVehicleTypeRepo vehicleTypeRepo)
        {
            _vehicleTypeRepo = vehicleTypeRepo;
        }
        public ResponseViewModel Add(VehicleTypeRequest vehicleTypeRequest)
        {
            var response = new ResponseViewModel();

            var vehicleType = new VehicleType()
            {
                
                name = vehicleTypeRequest.name,
                createDate = DateTime.UtcNow,
                createdBy = vehicleTypeRequest.createdBy
                
            };

            _vehicleTypeRepo.Add(vehicleType);
            var saving = _vehicleTypeRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = "Id : " + vehicleType.id;
            return response;
        }

        public ResponseViewModel Delete(int id)
        {
            var response = new ResponseViewModel();

            var vehicleType = _vehicleTypeRepo.Get(p => p.id == id && !p.isDeleted);

            if (vehicleType == null)
            {
                response.IsSuccess = false;
                response.Message = "vehicleType bulunamadı.";
                return response;
            }

            vehicleType.isDeleted = true;

            _vehicleTypeRepo.Update(vehicleType);
            var saving = _vehicleTypeRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = vehicleType;
            return response;
        }

        public ResponseViewModel Get(int id)
        {
            var response = new ResponseViewModel();

            response.Data = _vehicleTypeRepo.Get(p => p.id == id && !p.isDeleted);

            return response;
        }
        public ResponseViewModel List()
        {
            var response = new ResponseViewModel();

            response.Data = _vehicleTypeRepo.List(p => !p.isDeleted).ToList();

            return response;
        }

        public ResponseViewModel Update(VehicleTypeRequest vehicleTypeRequest)
        {
            var response = new ResponseViewModel();
            
            var vehicleType = new VehicleType()
            {
                id = vehicleTypeRequest.id,
                name = vehicleTypeRequest.name,
                createdBy = vehicleTypeRequest.createdBy,
               
                modifyDate = DateTime.UtcNow,
                modifiedBy = vehicleTypeRequest.modifiedBy
              
            };

            _vehicleTypeRepo.Update(vehicleType);
            var saving = _vehicleTypeRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            return response;
        }

    }
}
