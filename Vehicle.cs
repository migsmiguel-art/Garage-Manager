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
        private int year;
        private string make;
        private string model;
        private string trim;
        private int odometer;
        private string plateNum;
        private string VIN;


        public Vehicle(string nickname, string type, int year, string make, string model, string trim, int odometer, string plateNum, string VIN)
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
            return $"{nickname}, {year}, {make}, {model}";

        }


    }


}
