using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NabeelKhan.Models
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public string price { get; set; }


    }


    public class VehicleContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}