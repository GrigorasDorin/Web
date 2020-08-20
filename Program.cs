using System;

namespace Web
{
    class Program
    {
        static void Main(string[] args)
        {
            var activity = new ExecuteProcessActivity("dotnet");

            System.Console.WriteLine("Invoking ((IExecuteProcessActivity)activity).Run()...");
            ((IExecuteProcessActivity)activity).Run();

            System.Console.WriteLine("Invoking activity.Run()...");
            activity.Run();
        }
    }
}
