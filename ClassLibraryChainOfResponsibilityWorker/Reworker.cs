namespace ClassLibraryChainOfResponsibilityWorker
{
    public class Reworker
    {
        public bool Director { get; set; }

        public bool Deputy { get; set; }

        public bool Worker { get; set; }

        public bool Intern { get; set; }

        public Reworker(bool dr, bool dp, bool wr, bool it) {
            Director = dr;
            Deputy = dp;
            Worker = wr;
            Intern = it;
        }
    }
}
