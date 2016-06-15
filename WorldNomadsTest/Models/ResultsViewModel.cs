using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldNomadsTest.Models
{
    public class ResultsViewModel
    {
        public int Number { get; set; }
        public List<int> Fibonacci { get; set; }
        public List<int> AllNumbers { get; set; }
        public List<int> AllOddNumbers { get; set; }
        public List<int> AllEvenNumbers { get; set; }
        public List<string> AllNumbersMultiple { get; set; }

    }
}