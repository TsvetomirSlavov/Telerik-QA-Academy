namespace QA.Framework.Core.Helpers
{
    using System;
    using System.Threading;

    public static class EventsWaiter
    {
        public static void WaitForEvent(Func<bool> predicate, int timeout)
        {
            var waitStart = DateTime.Now;

            while (true)
            {
                if (predicate())
                {
                    break;
                }

                if ((DateTime.Now - waitStart).TotalSeconds > timeout)
                {
                    throw new Exception("Timed out waiting for condition!");
                }

                Thread.Sleep(100);
            }
        }
    }
}

