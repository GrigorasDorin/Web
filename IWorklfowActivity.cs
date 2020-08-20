namespace Web
{
    public interface IWorklfowActivity
    {
        // Private and, therefore, not virtual
        private void Start() => System.Console.WriteLine("IWorkflowActivity.Start()...");

        // Sealed to prevent overrinding
        sealed void Run()
        {
            try
            {
                Start();
                InternalRun();
            }
            finally
            {
                Stop();
            }
        }

        protected void InternalRun();
        private void Stop() => System.Console.WriteLine("IWorkflowActivity.Stop()...");
    }
}