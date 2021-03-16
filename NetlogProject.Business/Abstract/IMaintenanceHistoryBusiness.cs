using NetlogProject.Entity.Request;
using NetlogProject.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Business.Abstract
{
    public interface IMaintenanceHistoryBusiness
    {
        ResponseViewModel Get(int id);
        ResponseViewModel Add(MaintenanceHistoryRequest maintenanceHistoryRequest);
        ResponseViewModel Update(MaintenanceHistoryRequest maintenanceHistoryRequest);
        ResponseViewModel Delete(int id);
        ResponseViewModel List();
    }
}
