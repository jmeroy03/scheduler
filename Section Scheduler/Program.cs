﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section_Scheduler
{
    static class Program
    {
        public const String CONNECTION_STRING = "Data Source=localhost;" +
            "Initial Catalog=database;" +
            "User id=root;" +
            "Password=root;";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSubjects());
            //Application.Run(new FrmRoom());
        }
    }
}
