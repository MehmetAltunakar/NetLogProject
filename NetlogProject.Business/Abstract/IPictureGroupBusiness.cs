using NetlogProject.Entity.Request;
using NetlogProject.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Business.Abstract
{
    public interface IPictureGroupBusiness
    {
        ResponseViewModel Get(int id);
        ResponseViewModel Add(PictureGroupRequest pictureGroupRequest);
        ResponseViewModel Update(PictureGroupRequest pictureGroupRequest);
        ResponseViewModel Delete(int id);
        ResponseViewModel List();
    }
}
