using System.ComponentModel;

namespace MarketServiceDAL.ViewModel
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        [DisplayName("ФИО Клиента")]
        public string CustomerFIO { get; set; }
        [DisplayName("Статус")]
        public string State { get; set; }
        [DisplayName("Сумма")]
        public int? Sum { get; set; }
    }
}
