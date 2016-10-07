using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FusionChart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ServiceRevenue()
        {
            var countryList = new List<string>
            {
                "Hong Kong",
                "Indonesia",
                "Korea",
                "Malaysia",
                "Philippines",
                "Singapore",
                "Singapore Energy",
                "Singapore BMA",
                "Thailand",
                "Taiwan",
                "Vietnam",
                "Japan",
                "Greater China",
                "Asean",
                "Asia"
            };

            var reportlist = new List<string>
            {
                "Specialty Client Service Revenue",
                "Revenue by each specialty and class",
                "CSR Performance",
                "Specialty Contribution",
                "RevenueMatric Matric Comparison"
            };

            ViewBag.CountrySelectList = new SelectList(countryList);
            ViewBag.ReportSelectList = new SelectList(reportlist);
            return View();
        }

        public ActionResult SpecialtyCSR()
        {
            return View();
        }

        public ActionResult SpecialtySales()
        {
            return View();
        }

        public ActionResult SpecialtyContributions()
        {
            return View();
        }

        public ActionResult RevenueMatric()
        {
            return View();
        }

        public ActionResult Gauge()
        {
            return View();
        }

        public ActionResult Map()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult StockTicker()
        {
            return View();
        }

        public ActionResult PieAndDoughnut()
        {
            return View();
        }

        public ActionResult MultiSeries()
        {
            return View();
        }

        public ActionResult Pareto()
        {
            return View();
        }
    }
}