using System.Collections.Generic;

namespace midterm.Models
{
    public class OrderFormApplication
    {
        public string ErrorMessage { get; set; }
        public OrderForm OrderForm { get; set; }
        public List<Cities> Pair_of_cities { get; set; }
        public List<WeightOfProd> WeightOfProd { get; set; }
        public List<DeliveryType> DeliveryTypes { get; set; }
    }
}