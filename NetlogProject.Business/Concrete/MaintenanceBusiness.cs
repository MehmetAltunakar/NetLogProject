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
    public class MaintenanceBusiness : IMaintenanceBusiness
    {
        private readonly IMaintenanceRepo _maintenanceRepo;
        private readonly IUserRepo _userRepo;
        private readonly IPictureGroupRepo _pictureGroupRepo;
        private readonly IVehicleRepo _vehicleRepo;

        public MaintenanceBusiness(IMaintenanceRepo maintenance, IUserRepo userRepo, IPictureGroupRepo pictureGroupRepo, IVehicleRepo vehicleRepo)
        {
            _maintenanceRepo = maintenance;
            _userRepo = userRepo;
            _pictureGroupRepo = pictureGroupRepo;
            _vehicleRepo = vehicleRepo;
    }
        public ResponseViewModel Add(MaintenanceRequest maintenanceRequest)
        {
            var response = new ResponseViewModel();
            var createdUser = _userRepo.Get(x => x.id == maintenanceRequest.createdBy && !x.isDeleted);

            if (createdUser == null)
            {
                response.IsSuccess = false;
                response.Message = "CreatedBy bulunamadı";
                return response;
            }
            var pictureGroupId = _pictureGroupRepo.Get(x => x.id == maintenanceRequest.pictureGroupId && !x.isDeleted);

            if (pictureGroupId == null)
            {
                response.IsSuccess = false;
                response.Message = "Picture bulunamadı";
                return response;
            }
            var vehicleId = _vehicleRepo.Get(x => x.id == maintenanceRequest.vehicleId && !x.isDeleted);

            if (vehicleId == null)
            {
                response.IsSuccess = false;
                response.Message = "VehicleId bulunamadı";
                return response;
            }

            var maintenance = new Maintenance()
            {
                vehicleId = maintenanceRequest.vehicleId,
                userId = maintenanceRequest.userId,
                description=maintenanceRequest.description,
                responsibleUserId=maintenanceRequest.responsibleUserId,
                locationLatitude=maintenanceRequest.locationLatitude,
                locationLongitude=maintenanceRequest.locationLongitude,
                statusId=maintenanceRequest.statusId,
                pictureGroupId = maintenanceRequest.pictureGroupId,
                createDate = DateTime.UtcNow,
                createdBy = maintenanceRequest.createdBy
                
            };

            _maintenanceRepo.Add(maintenance);
            var saving = _maintenanceRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = "Id : " + maintenance.id;
            return response;
        }

        public ResponseViewModel Delete(int id)
        {
            var response = new ResponseViewModel();

            var maintenance = _maintenanceRepo.Get(p => p.id == id && !p.isDeleted);

            if (maintenance == null)
            {
                response.IsSuccess = false;
                response.Message = "maintenance kaydı bulunamadı.";
                return response;
            }

            maintenance.isDeleted = true;

            _maintenanceRepo.Update(maintenance);
            var saving = _maintenanceRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = maintenance;
            return response;
        }

        public ResponseViewModel Get(int id)
        {
            var response = new ResponseViewModel();

            response.Data = _maintenanceRepo.Get(p => p.id == id && !p.isDeleted);

            return response;
        }

        public ResponseViewModel List()
        {
            var response = new ResponseViewModel();

            response.Data = _maintenanceRepo.List(p=>!p.isDeleted).ToList();

            return response;
        }

        public ResponseViewModel Update(MaintenanceRequest maintenanceRequest)
        {
            var response = new ResponseViewModel();
            
            var maintenance = new Maintenance()
            {
               
                vehicleId = maintenanceRequest.vehicleId,
                userId = maintenanceRequest.userId,
                description = maintenanceRequest.description,
                pictureGroupId = maintenanceRequest.pictureGroupId,
                responsibleUserId = maintenanceRequest.responsibleUserId,
                locationLatitude = maintenanceRequest.locationLatitude,
                locationLongitude = maintenanceRequest.locationLongitude,
                statusId = maintenanceRequest.statusId,
                createdBy = maintenanceRequest.createdBy,
                modifyDate = DateTime.UtcNow,
                modifiedBy = maintenanceRequest.modifiedBy
              
            };

            _maintenanceRepo.Update(maintenance);
            var saving = _maintenanceRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            return response;
        }

    }
}
