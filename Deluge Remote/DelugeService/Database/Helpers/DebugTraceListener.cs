﻿using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService.Database.Helpers
{
    public class DebugTraceListener : ITraceListener
    {
        public void Receive(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
