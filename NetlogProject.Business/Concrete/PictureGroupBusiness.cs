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
    public class PictureGroupBusiness : IPictureGroupBusiness
    {
        private readonly IPictureGroupRepo _pictureGroupRepo;
        public PictureGroupBusiness(IPictureGroupRepo pictureGroupRepo)
        {
            _pictureGroupRepo = pictureGroupRepo;
        }
        public ResponseViewModel Add(PictureGroupRequest pictureGroupRequest)
        {
            var response = new ResponseViewModel();

            var pictureGroup = new PictureGroup()
            {
                //id = pictureGroupRequest.id,
                pictureImage = pictureGroupRequest.pictureImage,
                createDate = DateTime.UtcNow,
                createdBy = pictureGroupRequest.createdBy
                
            };

            _pictureGroupRepo.Add(pictureGroup);
            var saving = _pictureGroupRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = "Id : " + pictureGroup.id;
            return response;
        }

        public ResponseViewModel Delete(int id)
        {
            var response = new ResponseViewModel();

            var pictureGroup = _pictureGroupRepo.Get(p => p.id == id && !p.isDeleted);

            if (pictureGroup == null)
            {
                response.IsSuccess = false;
                response.Message = "pictureGroup bulunamadı.";
                return response;
            }

            pictureGroup.isDeleted = true;

            _pictureGroupRepo.Update(pictureGroup);
            var saving = _pictureGroupRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            response.Data = pictureGroup;
            return response;
        }

        public ResponseViewModel Get(int id)
        {
            var response = new ResponseViewModel();

            response.Data = _pictureGroupRepo.Get(p => p.id == id && !p.isDeleted);

            return response;
        }

        public ResponseViewModel Update(PictureGroupRequest pictureGroupRequest)
        {
            var response = new ResponseViewModel();
            
            var pictureGroup = new PictureGroup()
            {
                id = pictureGroupRequest.id,
                pictureImage = pictureGroupRequest.pictureImage,
                createdBy = pictureGroupRequest.createdBy,
               
                modifyDate = DateTime.UtcNow,
                modifiedBy = pictureGroupRequest.modifiedBy
              
            };

            _pictureGroupRepo.Update(pictureGroup);
            var saving = _pictureGroupRepo.SaveChanges();
            if (!saving)
                response.IsSuccess = false;

            return response;
        }

    }
}
