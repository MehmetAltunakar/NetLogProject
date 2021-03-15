using NetlogProject.Entity.Request;
using NetlogProject.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Business.Abstract
{
    public interface IActionTypeBusiness
    {
        ResponseViewModel Get(int id);
        ResponseViewModel Add(ActionTypeRequest actionTypeRequest);
        ResponseViewModel Update(ActionTypeRequest actionTypeRequest);
        ResponseViewModel Delete(int id);
    }
}
