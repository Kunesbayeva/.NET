using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using midterm.Models;

public class OrdersController :Controller{

        private City cities;

        public OrdersController()
        {
            cities = new City();
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            OrderForm ordersForm = new OrderForm()
            {
                CityB = "",
                CityA = "",
                WeightOfProd = 0,
                TypeId = 0
            };
            
            var form = new OrdersFormApp()
            {
                CityPair = cities.Pair_of_cities,
                OrdersForm = ordersForm,
                WeightTypes = cities.WeightOfProd,
                DeliveryTypes = cities.GetDeliveryTypes()
            };
            
            return View(form);
        }
}