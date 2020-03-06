namespace ClassLibraryChainOfResponsibilityWorker
{
    public class Worker : WorkerHandler
    {
        public override string Handle(Reworker reworker)
        {
            if (reworker.Worker == true)
            {
                return "Рабочий подтвердил заказ";
            }
            else if (Successor != null)
            {
                return Successor.Handle(reworker);
            }
            else
            {
                return "Рабочий занят";
            }
        }
    }
}
