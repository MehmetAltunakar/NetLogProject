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
    public class ActionTypeBusiness : IActionTypeBusiness
    {
        private readonly IActionTypeRepo _actionTypeRepo;
        public ActionTypeBusiness(IActionTypeRepo actionType)
        {
            _actionTypeRepo = actionType;
        }
        public ResponseViewModel Add(ActionTypeRequest actionTypeRequest)
        {
            var response = new ResponseViewModel();

            var actionType = new ActionType()
            {
                id = actionTypeRequest.id,
                name = actionTypeRequest.name,
                createDate = DateTime.UtcNow,
                createdBy = actionTypeRequest.createdBy
                
            };

            _actionTypeRepo.Add(actionType);
            var saving = _actionTypeRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = "Id : " + actionType.id;
            return response;
        }

        public ResponseViewModel Delete(int id)
        {
            var response = new ResponseViewModel();

            var actionType = _actionTypeRepo.Get(p => p.id == id && !p.isDeleted);

            if (actionType == null)
            {
                response.IsSuccess = false;
                response.Message = "status bulunamadı.";
                return response;
            }

            actionType.isDeleted = true;

            _actionTypeRepo.Update(actionType);
            var saving = _actionTypeRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = actionType;
            return response;
        }

        public ResponseViewModel Get(int id)
        {
            var response = new ResponseViewModel();

            response.Data = _actionTypeRepo.Get(p => p.id == id && !p.isDeleted);

            return response;
        }

        public ResponseViewModel Update(ActionTypeRequest actionTypeRequest)
        {
            var response = new ResponseViewModel();
            
            var actionType = new ActionType()
            {
                id = actionTypeRequest.id,
                name = actionTypeRequest.name,
                createdBy = actionTypeRequest.createdBy,
               
                modifyDate = DateTime.UtcNow,
                modifiedBy = actionTypeRequest.modifiedBy
              
            };

            _actionTypeRepo.Update(actionType);
            var saving = _actionTypeRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            return response;
        }

    }
}
