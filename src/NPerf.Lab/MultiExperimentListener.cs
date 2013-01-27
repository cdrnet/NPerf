﻿namespace NPerf.Lab
{
    using System.Linq;
    using NPerf.Core;
    using NPerf.Core.TestResults;
    using NPerf.Lab.Queueing;
    using NPerf.Lab.Threading;

    internal class MultiExperimentListener : MultiRunnable
    {
        public MultiExperimentListener(string[] names, ReactiveQueue<TestResult> queue)
        {
            this.SetRunnables((from name in names
                               select (IRunnable)new SingleExperimentListener(name, queue)).ToArray());
        }
    }
}