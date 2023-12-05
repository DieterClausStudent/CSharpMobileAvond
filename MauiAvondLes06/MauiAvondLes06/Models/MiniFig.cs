using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAvondLes06.Models
{
    public class MiniFig
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Race { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Race})";
        }
    }
}
