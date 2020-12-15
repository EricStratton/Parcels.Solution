using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class ParcelsController: Controller
    {
        [HttpGet("/parcels")]
        public ActionResult Index(double length, double width, double height, double weight, double cost)
        {
            Parcel parcel = new Parcel(length, width, height, weight, cost);
            return View(parcel);
        }

        [HttpGet("/parcels/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/parcels")]
        public ActionResult Create(double length, double width, double height, double weight, double cost)
        {
            Parcel parcel = new Parcel(length, width, height, weight, cost);
            parcel.SetCost();
            return RedirectToAction("Index", parcel);
        }
    }
}