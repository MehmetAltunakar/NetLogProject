using NetlogProject.Entity.Request;
using NetlogProject.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Business.Abstract
{
    public interface IStatusBusiness
    {
        ResponseViewModel Get(int id);
        ResponseViewModel Add(StatusRequest statusRequest);
        ResponseViewModel Update(StatusRequest statusRequest);
        ResponseViewModel Delete(int id);
    }
}
