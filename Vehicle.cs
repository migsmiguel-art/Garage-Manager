using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Manager
{
    public class Vehicle
    {
        private string nickname;
        private string type;
        private string year;
        private string make;
        private string model;
        private string trim;
        private string odometer;
        private string plateNum;
        private string VIN;


        public Vehicle(string nickname, string type, string year, string make, string model, string trim, string odometer, string plateNum, string VIN)
        {
            this.nickname = nickname;
            this.type = type;
            this.year = year;
            this.make = make;
            this.model = model;
            this.trim = trim;
            this.odometer = odometer;
            this.plateNum = plateNum;
            this.VIN = VIN;
        }

        public override string ToString()
        {
            // return $"firstName={firstName}, lastName={lastName}, ssn={ssn}, hireDate={hireDate.ToShortDateString()}";
            return $"{year} {make} {model}";

        }


    }


}
