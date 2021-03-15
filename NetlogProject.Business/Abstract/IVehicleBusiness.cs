using NetlogProject.Entity.Request;
using NetlogProject.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Business.Abstract
{
    public interface IVehicleBusiness
    {
        ResponseViewModel Get(int id);
        ResponseViewModel Add(VehicleRequest vehicleRequest);
        ResponseViewModel Update(VehicleRequest vehicleRequest);
        ResponseViewModel Delete(int id);
    }
}
