using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrow.Models.ViewModels
{
    public class ParkingspotViewModel
    {
        public int mincover { get; set; }
        public int sensortype { get; set; }
        public string restcall { get; set; }
        public string restheader { get; set; }
        public string GapIds { get; set; }
        public string ViewIds { get; set; }
        public int occupied { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public double ax { get; set; }
        public double ay { get; set; }
        public double bx { get; set; }
        public double by { get; set; }
        public double cx { get; set; }
        public double cy { get; set; }
        public double dx { get; set; }
        public double dy { get; set; }
        public string rawRefData { get; set; }

        public static implicit operator Parkingspot(ParkingspotViewModel vm)
        {
            return new Parkingspot
            {
                mincover = vm.mincover,
                sensortype = vm.sensortype,
                restcall = vm.restcall,
                restheader = vm.restheader,
                GapIds = vm.GapIds,
                ViewIds = vm.ViewIds,
                occupied = vm.occupied,
                Name = vm.Name,
                Comment = vm.Comment,
                ax = vm.ax,
                ay = vm.ay,
                bx = vm.bx,
                by = vm.by,
                cx = vm.cx,
                cy = vm.cy,
                dx = vm.dx,
                dy = vm.dy,
                rawRefData = vm.rawRefData
            };
        }
        public static implicit operator ParkingspotViewModel(Parkingspot parkingspot)
        {
            return new Parkingspot
            {
                mincover = parkingspot.mincover,
                sensortype = parkingspot.sensortype,
                restcall = parkingspot.restcall,
                restheader = parkingspot.restheader,
                GapIds = parkingspot.GapIds,
                ViewIds = parkingspot.ViewIds,
                occupied = parkingspot.occupied,
                Name = parkingspot.Name,
                Comment = parkingspot.Comment,
                ax = parkingspot.ax,
                ay = parkingspot.ay,
                bx = parkingspot.bx,
                by = parkingspot.by,
                cx = parkingspot.cx,
                cy = parkingspot.cy,
                dx = parkingspot.dx,
                dy = parkingspot.dy,
                rawRefData = parkingspot.rawRefData
            };
        }
    }
}
