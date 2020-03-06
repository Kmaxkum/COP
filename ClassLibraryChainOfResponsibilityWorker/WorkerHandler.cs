namespace ClassLibraryChainOfResponsibilityWorker
{
    public abstract class WorkerHandler
    {
        public WorkerHandler Successor { get; set; }

        public abstract string Handle(Reworker reworker);
    }
}
