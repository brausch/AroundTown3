﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AroundTown3.Models
{
    [Table("Locations")]
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        public string LocationName { get; set; }
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public virtual Route Route { get; set; }

        public Location(string locationName, string address, string city, string state, string zip, int locationId = 0)
        {
            LocationId = locationId;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            LocationId = locationId;
        }

        public Location() { }
    }
}
