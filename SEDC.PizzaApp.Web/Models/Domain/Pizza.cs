﻿namespace SEDC.PizzaApp.Web.Models.Domain
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public bool IsOnPromotion { get; set; }

    }
}
