using NetlogProject.Entity.Request;
using NetlogProject.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Business.Abstract
{
    public interface IVehicleTypeBusiness
    {
        ResponseViewModel Get(int id);
        ResponseViewModel Add(VehicleTypeRequest vehicleTypeRequest);
        ResponseViewModel Update(VehicleTypeRequest vehicleTypeRequest);
        ResponseViewModel Delete(int id);
    }
}
