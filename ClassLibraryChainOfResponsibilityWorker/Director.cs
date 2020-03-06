namespace ClassLibraryChainOfResponsibilityWorker
{
    public class Director : WorkerHandler
    {
        public override string Handle(Reworker reworker)
        {
            if (reworker.Director == true)
            {
                return "Директор подтвердил заказ";
            }
            else if (Successor != null)
            {
                return Successor.Handle(reworker);
            }
            else
            {
                return "Директор занят";
            }
        }
    }
}
