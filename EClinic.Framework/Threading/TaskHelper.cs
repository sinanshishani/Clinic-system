using System;
using System.Threading.Tasks;

namespace EClinic.Framework.Threading
{
    public class TaskHelper
    {
        public static TResult RunSync<TResult>(Func<Task<TResult>> function)
        {
            return Task.Run(async () => await function()).Result;
        }
    }
}
