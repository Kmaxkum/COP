using MarketModel;

namespace MarketServiceDAL.BindingModels
{
    public class CustomerBindingModel
    {
        public int Id { get; set; }
        public string CustomerFIO { get; set; }
        public CustomerStatus State { get; set; }
        public int? Sum { get; set; }
    }
}
