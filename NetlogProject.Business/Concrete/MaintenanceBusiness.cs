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
    public class MaintenanceBusiness : IMaintenanceBusiness
    {
        private readonly IMaintenanceRepo _maintenanceRepo;
        public MaintenanceBusiness(IMaintenanceRepo maintenance)
        {
            _maintenanceRepo = maintenance;
        }
        public ResponseViewModel Add(MaintenanceRequest maintenanceRequest)
        {
            var response = new ResponseViewModel();

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

        public ResponseViewModel Update(MaintenanceRequest maintenanceRequest)
        {
            var response = new ResponseViewModel();
            
            var maintenance = new Maintenance()
            {
                id = maintenanceRequest.id,
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
