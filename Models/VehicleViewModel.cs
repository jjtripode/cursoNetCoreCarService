
using System;

namespace CarServiceFronted.Models
{
    public class VehicleViewModel
    {
        public Vehicle[] Items { get; set; }

        public AddVehicleViewModel AddVehicleViewModel  { get; set; }
        public AddServiceViewModel AddServiceViewModel { get;  set; }
        public ServiceType[] ServicesType { get;  set; }
        public ServiceStatus[] StatusList { get;  set; }
    }
}