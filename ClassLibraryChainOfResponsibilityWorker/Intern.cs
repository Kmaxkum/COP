namespace ClassLibraryChainOfResponsibilityWorker
{
    public class Intern : WorkerHandler
    {
        public override string Handle(Reworker reworker)
        {
            if (reworker.Intern == true)
            {
                return "Стажер подтвердил заказ";
            }
            else if (Successor != null)
            {
                return Successor.Handle(reworker);
            }
            else
            {
                return "Стажер занят";
            }
        }
    }
}
