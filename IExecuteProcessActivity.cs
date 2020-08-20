namespace Web
{
    public interface IExecuteProcessActivity : IWorklfowActivity
    {
        protected void RedirectStandardInOut() =>
            System.Console.WriteLine("IExecuteProcessActivity.RedirectStandardInOut()...");

        void IWorklfowActivity.InternalRun()
        {
            RedirectStandardInOut();
            ExecuteProcess();
            RestoreStandardInOut();
        }

        protected void ExecuteProcess();
        protected void RestoreStandardInOut() =>
            System.Console.WriteLine("IExecuteProcessActivity.RestoreStandardInOut()...");
    }
}