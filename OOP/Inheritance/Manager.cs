using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance
{
    class Manager : Employee
    {
        public Manager(string name, int age, int salary, string ssn, int stopOptions)
           : base(name, age, salary, ssn)
        {


            this.StockOptions = stopOptions;
        }

        public int StockOptions { get; set; }
    }
}
