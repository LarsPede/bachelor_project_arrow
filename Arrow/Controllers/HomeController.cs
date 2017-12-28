using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Arrow.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Arrow.Models.ViewModels;

namespace Arrow.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage placementResponse = await client.GetAsync("http://ec2-18-221-88-228.us-east-2.compute.amazonaws.com:8000/api/get_all_channel_data/Frederiksberg_Parking_spots/30df6430-b6d0-4c06-ab26-b8d66178eecf");
            var result = await placementResponse.Content.ReadAsStringAsync();
            var parkingspots = JsonConvert.DeserializeObject<List<Parkingspot>>(result);
            HttpResponseMessage statusResponse = await client.GetAsync("http://ec2-18-221-88-228.us-east-2.compute.amazonaws.com:8000/api/get_all_channel_data/Parking_spot_status/30df6430-b6d0-4c06-ab26-b8d66178eecf");
            result = await statusResponse.Content.ReadAsStringAsync();
            var occupiedParkingSpots = JsonConvert.DeserializeObject<List<Parkingspot>>(result);
            var parkingspotsWithStatus = parkingspots.Select(x =>
            {
                if (occupiedParkingSpots.Any(y => y.GapIds == x.GapIds))
                {
                    x.occupied = 1;
                }
                
                return x;
            }).ToList();
            MapViewModel response = new MapViewModel();
            response.Parkingspots = parkingspotsWithStatus;


            return View(response);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
