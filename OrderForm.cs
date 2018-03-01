using System;

namespace midterm.Models
{
    public class OrderForm
    {
        public string CityB { get; set; }
        public string CityA { get; set; }
        public int WeightOfProd { get; set; }
        public int TypeId { get; set; }
        public DateTime Until_Date { get; set; }
    }
}