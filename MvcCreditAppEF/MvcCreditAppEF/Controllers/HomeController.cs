using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcCreditAppEF.Data;
using MvcCreditAppEF.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCreditAppEF.Controllers
{
    public class HomeController : Controller
    {
        private CreditContext _dbContext;

        public HomeController(CreditContext context)
        {
            _dbContext = context;
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult Index()
        {
            GiveCredits();
            return View(_dbContext.Bids);
        }

        [Authorize(Roles = "admin, user")]
        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveCredits();
            var allBids = _dbContext.Bids.ToList();
            ViewBag.Bids = allBids;
            return View();
        }

        [Authorize(Roles = "admin, user")]
        [HttpPost]
        public ActionResult CreateBid(Bid newBid)
        {
            newBid.BidDate = DateTime.Now;
            _dbContext.Bids.Add(newBid);
            _dbContext.SaveChanges();
            string response = $"Спасибо, <b>{newBid.Name}</b>, за выбор нашего банка. Ваша заявка будет рассмотрена в течении 10 дней.";
            return Content($"<html><body>{response}</body></html>", "text/html", System.Text.Encoding.Unicode);
        }

        [Authorize(Roles = "admin")]
        public ActionResult BidSearch(string name)
        {
            var allBids = _dbContext.Bids.Where(a => a.CreditHead.Contains(name));
            var bidsList = allBids == null ? new List<Bid>() : allBids.ToList();

            if (bidsList.Count == 0)
            {
                return Content($"Указанный кредит {name} не найден");
            }
            return PartialView("_BidSearch", bidsList);
        }

        private void GiveCredits()
        {
            var allCredits = _dbContext.Credits.ToList();
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
