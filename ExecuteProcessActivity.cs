namespace Web
{
    public class ExecuteProcessActivity : IExecuteProcessActivity
    {
        public ExecuteProcessActivity(string exePath)
        {
            ExecutableName = exePath ?? throw new System.ArgumentException(nameof(exePath));
        }

        public string ExecutableName { get; }

        void IExecuteProcessActivity.RedirectStandardInOut() =>
            System.Console.WriteLine("ExecuteProcessActivity.RedirectStandardInOut()...");

        void IExecuteProcessActivity.ExecuteProcess() =>
            System.Console.WriteLine("ExecuteProcessActivity.IExecuteProcessActivity.ExecutProcess()...");

        public void Run()
        {
            ExecuteProcessActivity activity = new ExecuteProcessActivity("dotnet");
            // Protected members cannot be invoked by the implementing class...
            // ((IWorkflowActivity)this).InternalRun();
            // activity.RedirectStandardInOut();
            // activity.ExecuteProcess();
            System.Console.WriteLine($"Executing non-polymorphic Run() with process {activity.ExecutableName}");
        }
    }
}