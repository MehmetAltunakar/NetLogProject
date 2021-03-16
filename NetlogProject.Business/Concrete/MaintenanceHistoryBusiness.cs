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
    public class MaintenanceHistoryBusiness : IMaintenanceHistoryBusiness
    {
        private readonly IMaintenanceHistoryRepo _maintenanceHistoryRepo;
        public MaintenanceHistoryBusiness(IMaintenanceHistoryRepo maintenanceHistory)
        {
            _maintenanceHistoryRepo = maintenanceHistory;
        }
        public ResponseViewModel Add(MaintenanceHistoryRequest maintenanceHistoryRequest)
        {
            var response = new ResponseViewModel();

            var maintenanceHistory = new MaintenanceHistory()
            {
                //id = maintenanceHistoryRequest.id,
                maintenanceId = maintenanceHistoryRequest.maintenanceId,
                actionTypeId = maintenanceHistoryRequest.actionTypeId,
                text= maintenanceHistoryRequest.text,
                createDate = DateTime.UtcNow,
                createdBy = maintenanceHistoryRequest.createdBy
                
            };

            _maintenanceHistoryRepo.Add(maintenanceHistory);
            var saving = _maintenanceHistoryRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = "Id : " + maintenanceHistory.id;
            return response;
        }

        public ResponseViewModel Delete(int id)
        {
            var response = new ResponseViewModel();

            var maintenanceHistory = _maintenanceHistoryRepo.Get(p => p.id == id && !p.isDeleted);

            if (maintenanceHistory == null)
            {
                response.IsSuccess = false;
                response.Message = "maintenance kaydı bulunamadı.";
                return response;
            }

            maintenanceHistory.isDeleted = true;

            _maintenanceHistoryRepo.Update(maintenanceHistory);
            var saving = _maintenanceHistoryRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = maintenanceHistory;
            return response;
        }

        public ResponseViewModel Get(int id)
        {
            var response = new ResponseViewModel();

            response.Data = _maintenanceHistoryRepo.Get(p => p.id == id && !p.isDeleted);

            return response;
        }

        public ResponseViewModel Update(MaintenanceHistoryRequest maintenanceHistoryRequest)
        {
            var response = new ResponseViewModel();
            
            var maintenanceHistory = new MaintenanceHistory()
            {
                id = maintenanceHistoryRequest.id,
                maintenanceId = maintenanceHistoryRequest.maintenanceId,
                actionTypeId = maintenanceHistoryRequest.actionTypeId,
                text = maintenanceHistoryRequest.text,
                createdBy = maintenanceHistoryRequest.createdBy,
                modifyDate = DateTime.UtcNow,
                modifiedBy = maintenanceHistoryRequest.modifiedBy
              
            };

            _maintenanceHistoryRepo.Update(maintenanceHistory);
            var saving = _maintenanceHistoryRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            return response;
        }

    }
}
