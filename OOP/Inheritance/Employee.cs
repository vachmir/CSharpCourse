using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance
{
    class Employee
    {
        private string name;
        private int age;
        private int salary;
        private readonly string social_security_number;

        public Employee() { }

        public Employee(string name, int age, int salary, string ssn)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.social_security_number = ssn;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Age { get => this.age; set => this.age = value; }
        public int Salary { get => this.salary; set => this.salary = value; }
        public string SSN { get => this.social_security_number; }

    }
}
