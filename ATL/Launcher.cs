﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ATL
{
    class Launcher
    {
        public static void PlayGame()
        {
        Process.Start("wow.exe");
            Environment.Exit(0);
        }
        public static void LaunchWebsite(string url)
        {
            Process.Start(url);
        }
}
}
