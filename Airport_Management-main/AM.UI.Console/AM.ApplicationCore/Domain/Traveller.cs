﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }
        public override string ToString()
        {
            return this.Nationality+"  "+this.HealthInformation;
        }

        public override void PassengerType()
        {
            Console.WriteLine("I am a passenger I am a traveller");
        }
    }
}