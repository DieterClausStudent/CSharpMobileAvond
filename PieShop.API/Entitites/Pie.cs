﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PieShop.API.Entitites
{
    public class Pie
    {
        public Guid Id { get; set; }

        public string PieName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public double Price { get; set; }

        public double PurchasePrice { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public bool InStock { get; set; }
    }
}
