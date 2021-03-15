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
    public class VehicleBusiness : IVehicleBusiness
    {
        private readonly IVehicleRepo _vehicleRepo;
        public VehicleBusiness(IVehicleRepo vehicleRepo)
        {
            _vehicleRepo = vehicleRepo;
        }
        public ResponseViewModel Add(VehicleRequest vehicleRequest)
        {
            var response = new ResponseViewModel();

            var vehicle = new Vehicle()
            {
                id = vehicleRequest.id,
                plateNo = vehicleRequest.plateNo,
                vehicleTypeId = vehicleRequest.vehicleTypeId,
                userId = vehicleRequest.userId,
                createDate = DateTime.UtcNow,
                createdBy = vehicleRequest.createdBy
                
            };

            _vehicleRepo.Add(vehicle);
            var saving = _vehicleRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = "Id : " + vehicle.id;
            return response;
        }

        public ResponseViewModel Delete(int id)
        {
            var response = new ResponseViewModel();

            var vehicle = _vehicleRepo.Get(p => p.id == id && !p.isDeleted);

            if (vehicle == null)
            {
                response.IsSuccess = false;
                response.Message = "vehicle bulunamadı.";
                return response;
            }

            //_vehicleRepo.isDeleted = true;

            _vehicleRepo.Update(vehicle);
            var saving = _vehicleRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = vehicle;
            return response;
        }

        public ResponseViewModel Get(int id)
        {
            var response = new ResponseViewModel();

            response.Data = _vehicleRepo.Get(p => p.id == id && !p.isDeleted);

            return response;
        }

        public ResponseViewModel Update(VehicleRequest vehicleRequest)
        {
            var response = new ResponseViewModel();
            
            var vehicle = new Vehicle()
            {
                id = vehicleRequest.id,
                plateNo = vehicleRequest.plateNo,
                vehicleTypeId = vehicleRequest.vehicleTypeId,
                userId = vehicleRequest.userId,
                createdBy = vehicleRequest.createdBy,
                modifyDate = DateTime.UtcNow,
                modifiedBy = vehicleRequest.modifiedBy
              
            };

            _vehicleRepo.Update(vehicle);
            var saving = _vehicleRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            return response;
        }

    }
}
