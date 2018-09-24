﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Sockets;
using VWSWebApp.Models;

namespace VWSWebApp.Tools
{
    public static class GlobalVariables
    {
        public static string GlobalString { get; set; }
        public static int GlobalCount { get; set; }

        public static List<Socket> GlobalSocketList { get; set; }

        public static Socketcmd cmd { get; set; }
    }
}