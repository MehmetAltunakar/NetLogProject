using NetlogProject.Entity.Request;
using NetlogProject.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Business.Abstract
{
    public interface IUserBusiness
    {
        ResponseViewModel Get(int id);
        ResponseViewModel Add(UserRequest userRequest);
        ResponseViewModel Update(UserRequest userRequest);
        ResponseViewModel Delete(int id);
    }
}
