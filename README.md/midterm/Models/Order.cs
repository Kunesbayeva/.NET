using System;

namespace midterm.Models
{
    public class Order
    {
        public City cities { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public WeightOfProd WeightTOfPros { get; set; }
        public Cities  Pair_of_cities{ get; set; }
        public string DueDate { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
        public float TotalPrice { get; set; }
    }
}