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

        SelectList GetMonthList()
        {
            var list = new List<string>
            {
                "Jan",
                "Feb",
                "Mar",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
            return new SelectList(list);
        }

        SelectList GetYearList()
        {
            var list = new List<string>
            {
               "2016",
                "2015"
            };
            return new SelectList(list);
        }

        SelectList GetCountryList()
        {
            var list = new List<string>
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
            return new SelectList(list);
        }

        SelectList GetReportList()
        {
            var list = new List<string>
            {
                "Specialty Client Service Revenue",
                "Revenue by each specialty and class",
                "CSR Performance",
                "Specialty Contribution",
                "RevenueMatric Matric Comparison"
            };
            return new SelectList(list);
        }

        public ActionResult ServiceRevenue()
        {
            ViewBag.CountrySelectList = GetCountryList();
            ViewBag.ReportSelectList = GetReportList();

            ViewBag.MonthSelectList = GetMonthList();
            ViewBag.YearSelectList = GetYearList();
            return View();
        }

        public ActionResult SpecialtyCSR()
        {
            ViewBag.CountrySelectList = GetCountryList();
            ViewBag.ReportSelectList = GetReportList();

            ViewBag.MonthSelectList = GetMonthList();
            ViewBag.YearSelectList = GetYearList();
            return View();
        }

        public ActionResult SpecialtySales()
        {
            return View();
        }

        public ActionResult SpecialtyContributions()
        {
            ViewBag.CountrySelectList = GetCountryList();
            ViewBag.ReportSelectList = GetReportList();

            ViewBag.MonthSelectList = GetMonthList();
            ViewBag.YearSelectList = GetYearList();
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