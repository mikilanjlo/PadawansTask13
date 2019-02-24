using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    class Employee
    {
        private string surname;
        private int age;

        public Employee()
        {

        }

        public Employee(string surname, int age)
        {
            if (surname == null)
                throw new ArgumentNullException();
            if (surname == "" || age <= 0)
                throw new ArgumentException();
            this.surname = surname;
            this.age = age;
        }

        private string GetAge()
        {
            return "" + age;
        }

        public void SetSurname(string surname)
        {
            if (surname == null)
                throw new ArgumentNullException();
            if (surname == "")
                throw new ArgumentException();
            this.surname = surname;
        }

        public string GetInfo()
        {
            return $"Surname: {this.surname}, Age: {this.age}";
        }
    }
}
