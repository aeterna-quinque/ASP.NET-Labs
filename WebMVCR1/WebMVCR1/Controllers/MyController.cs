using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        private readonly ILogger<MyController> _logger;

        private static PersonRepository db = new PersonRepository();

        public MyController(ILogger<MyController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            ViewData["Mes"] = "хорошего настроения";
            return View();
        }

        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }
        
        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);
        }

        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }

        //public string Start(string hel)
        //{
        //    //string res = ExeEnum();
        //    //string res = ExeStruct();
        //    //string res = StudyCsharp.ExeSwitch(StudyCsharp.SetStatus(3));
        //    //string res = StudyCsharp.GetFunction(0, 9);
        //    //string res = ExeFactorial(5);
        //    //string res = ExeTriangle();
        //    //string res = ExeCircle();
        //    //string res = ExePolim();
        //    //string res = ExeCollection();
        //    string res = ExeTriangleCollection();
        //    return res;
        //}

        #region lab2
        public string ExeTriangleCollection()
        {
            List<Triangle> triangles = new List<Triangle>
            {
                new Triangle(12, 15, 15),
                new Triangle(5, 5, 5),
                new Triangle(15, 10, 12),
                new Triangle(6, 5, 3)
            };

            triangles.Add(new Triangle(7, 7, 7));
            triangles.Sort();

            StringBuilder str = new StringBuilder();
            foreach (Shape item in triangles)
            {
                str.AppendFormat("Это фигура {0}<p>", item.Name);
            }

            return str.ToString();
        }

        public string ExeCollection()
        {
            List<Circle> cirs = new List<Circle>
            {
                new Circle(12),
                new Circle(5),
                new Circle(15),
                new Circle(6)
            };

            cirs.Add(new Circle(7));
            cirs.Sort();

            StringBuilder str = new StringBuilder();
            foreach (Shape item in cirs)
            {
                str.AppendFormat("Это фигура {0}<p>", item.Name);
            }

            return str.ToString();
        }

        public string ExePolim()
        {
            StringBuilder str = new StringBuilder();
            Shape[] sh =
            {
                new Triangle(1, 2, 3),
                new Circle(5),
                new Triangle(5, 6, 8)
            };

            foreach (Shape item in sh)
            {
                str.AppendFormat("Это фигура {0}", item.Name + "<p>");
            }

            return str.ToString();
        }

        public string ExeCircle()
        {
            Circle circle = new Circle(3);
            string sq = string.Format("Площадь фигуры {0} равна: " +
                "{1:0.##}", circle.Name, circle.Area);
            return sq;
        }

        public string ExeTriangle()
        {
            Triangle tr1 = new Triangle(3, 5, 6);
            string sq1 = string.Format("Площадь фигуры {0} равна: " +
                "{1:0.##}", tr1.Name, tr1.Area);
            return sq1;
        }

        public string ExeFactorial(int x)
        {
            int f;
            bool ok = StudyCsharp.Factorial(x, out f);
            if (ok)
                return $"Факториал числа {x} равен {f}";
            else
                return "Невозможно вычислить факториал";
        }

        public string ExeStruct()
        {
            BankAccount goldBankAccount;
            goldBankAccount.accType = AccountType.Checking;
            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accNo = 123;

            string res = $"Информация о банковском счете: {goldBankAccount}";
            return res;
        }

        public string ExeEnum()
        {
            AccountType goldAccount = AccountType.Checking;
            AccountType platinumAccount = AccountType.Deposit;

            string res1 = string.Format("Тип банковского счета {0}", goldAccount);
            string res2 = string.Format("Тип банковского счета {0}", platinumAccount);
            string res = $"{res1}<p>{res2}";
            return res;
        }
        #endregion

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
