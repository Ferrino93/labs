﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using SharpProject.Airport;
using SharpProject.Lab41;
using SharpProject.Properties;
using SharpProject.sql;

namespace SharpProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            new AirportDbApp().RunProgram();
        }
    }
}