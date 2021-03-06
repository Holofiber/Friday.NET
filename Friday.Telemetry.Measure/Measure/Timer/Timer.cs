﻿using System;

namespace Friday.Telemetry.Measure.Measure.Timer
{
    /// <summary>
    /// A Timer is a combination of a Histogram and a Meter allowing us to measure the duration of a type of event, the rate of its occurrence and provide duration statistics
    /// </summary>
    public class Timer : IDisposable
    {
        public void Dispose()
        {
        }
    }
}
