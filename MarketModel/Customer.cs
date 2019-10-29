using System.ComponentModel.DataAnnotations;

namespace MarketModel
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string CustomerFIO { get; set; }
        public CustomerStatus State { get; set; }
        public int? Sum { get; set; }
    }
}
