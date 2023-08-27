using System;
using System.Diagnostics;

namespace IoC.DI.WinForm.Sample.Core.Helpers
{
    public static class TimerHelper
    {
        private static Stopwatch _stopwatch = new();
        private static Action _action;

        public static void Start(Action action)
        {
            _stopwatch.Start();
            _action = action;
        }

        public static void Stop()
        {
            _stopwatch.Stop();
            _action();
        }

        public static decimal GetResultInSeconds()
        {
            return Convert.ToDecimal(_stopwatch.ElapsedMilliseconds / 1000);
        }
    }
}
