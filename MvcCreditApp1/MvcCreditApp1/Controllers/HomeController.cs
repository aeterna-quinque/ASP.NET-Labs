using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCreditApp1.Data;
using MvcCreditApp1.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace MvcCreditApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private OldCreditContext db = new OldCreditContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            GiveCredits();
            return View();
        }

        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveCredits();
            var allBids = db.Bids.ToList();
            ViewBag.Bids = allBids;
            return View();
        }

        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.BidDate = DateTime.Now;
            db.Bids.Add(newBid);
            db.SaveChanges();
            return $"Спасибо, <b>{newBid.Name}</b>, за выбор нашего банка. " +
                $"Ваша заявка будет рассмотрена в течении 10 дней.";
        }

        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList();
            ViewBag.Credits = allCredits;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
