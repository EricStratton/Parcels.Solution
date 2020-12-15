using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class ParcelsController: Controller
    {
        [HttpGet("/parcels")]
        public ActionResult Index()
        {
            Parcel parcel = new Parcel();
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
            Parcels parcel = new Parcel(length, width, height, weight);
            double cost = parcel.CalculateCost();
            return RedirectToAction("Index", cost);
        }
    }
}