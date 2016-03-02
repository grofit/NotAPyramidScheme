using System;

namespace SimpleDependency
{
    /// <summary>
    /// It is debateable if this should be in its own assembly or reside within here
    /// however for the example I will just keep it within the same project to reduce
    /// the project verbosity
    /// </summary>
    public class DefaultLogger : ILogger
    {
        public void DoSomeLogging(string somethingToLog)
        {
            Console.WriteLine(somethingToLog);
        }
    }
}