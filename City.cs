using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using midterm.Models;

namespace midterm.Models{
    public class City{
         public List<Cities> Pair_of_cities { get; set; }
        public List<WeightOfProd> WeightOfProd { get; set; }
        public List<DeliveryType> DeliveryTypes { get; set; }
        static readonly string ordersPath = "Data/orders.csv";
        
        public static List<Order> Orders = orderStore.GetCollection();
        
        public City()
        {
            var cities = new List<string>()
            {
                "Almaty",
                "Astana",
                "Taldykorgan",
                "Shymkent",
                "Oskemen",
            };
            
            var randomizer = new Random();
            var citiesCopy = cities.ToList();
            
            Pair_of_cities = cities.SelectMany(x => citiesCopy, (x, y) => new CityPair()
            {
                DestinationCity = x, 
                OriginCity = y,
                DeliveryPrice = float.Parse((randomizer.NextDouble() * 1000).ToString())
            }).ToList();
            
            WeightOfProd = new List<WeightOfProd>();
            WeightOfProd.AddRange(new List<WeightOfProd>()
            {
                new WeightOfProd() { LowerWeight = "0", UpperWeight = "5", Price = 0, Id = 1},
                new WeightOfProd() { LowerWeight = "5", UpperWeight = "10", Price = 500, Id = 2 },
                new WeightOfProd() { LowerWeight = "10", UpperWeight = "30", Price = 1000, Id = 3 },
                new WeightOfProd() { LowerWeight = "30", UpperWeight = "50", Price = 2500, Id = 4 },
                new WeightOfProd() { LowerWeight = "50", UpperWeight = "100+", Price = 5000, Id = 5 },                
            });

            DeliveryTypes = new List<DeliveryType>()
            {
                new DeliveryType() {Type = "Ems", Price = 500, Id = 1},
                new DeliveryType() {Type = "Post", Price = 0, Id = 2},
                new DeliveryType() { Type = "Express", Price = 1000, Id = 3}
            };
        }
    }
}
    }
}