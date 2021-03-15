using NetlogProject.Entity.Request;
using NetlogProject.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Business.Abstract
{
    public interface IMaintenanceBusiness
    {
        ResponseViewModel Get(int id);
        ResponseViewModel Add(MaintenanceRequest maintenanceRequest);
        ResponseViewModel Update(MaintenanceRequest maintenanceRequest);
        ResponseViewModel Delete(int id);
    }
}
