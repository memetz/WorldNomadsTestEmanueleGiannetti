using System.Web.Mvc;
using WorldNomadsTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldNomadsTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Sequences()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sequences(SequenceViewModel vm)
        {
            if (ModelState.IsValid)
            {

                return View("Results", new ResultsViewModel {   Number = vm.Number, Fibonacci = Fibonacci(vm.Number), 
                                                                AllNumbers = AllNumbers(vm.Number), 
                                                                AllOddNumbers = AllOddNumbers(vm.Number),
                                                                AllEvenNumbers = AllEvenNumbers(vm.Number),
                                                                AllNumbersMultiple = AllNumbersMultiple(vm.Number)
                                                                });
            }
            else
            {
                return View();
            }
        }

        public List<int> AllNumbers(int n)
        {
            var allNumb = new List<int>();
            for (int i = 0; i <= n;i++ )
            {
                allNumb.Add(i);
            }
            return allNumb;
        }

        public List<int> AllOddNumbers(int n)
        {
            var allNumb = new List<int>();
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 1) allNumb.Add(i);
            }
            return allNumb;
        }

        public List<int> AllEvenNumbers(int n)
        {
            var allNumb = new List<int>();
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0) allNumb.Add(i);
            }
            return allNumb;
        }

        public List<string> AllNumbersMultiple(int n)
        {
            var allNumb = new List<string>();
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i != 0) allNumb.Add("Z");
                else if (i % 3 == 0 && i != 0) allNumb.Add("C");
                else if (i % 5 == 0 && i != 0) allNumb.Add("E");
                else allNumb.Add(i.ToString());
            }
            return allNumb;
        }

        public int FibonacciRecursive(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        public List<int> Fibonacci(int n)
        {
            var fibo = new List<int>();

            for (int i = 0; i < n; i++)
            {
                fibo.Add(Fibo(i));
            }

            return fibo;
        }

        public int Fibo(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}