namespace ClassLibraryChainOfResponsibilityWorker
{
    public class Deputy : WorkerHandler
    {
        public override string Handle(Reworker reworker)
        {
            if (reworker.Deputy == true)
            {
                return "Заместитель директора подтвердил заказ";
            }
            else if (Successor != null)
            {
                return Successor.Handle(reworker);
            }
            else
            {
                return "Заместитель директора занят";
            }
        }
    }
}
