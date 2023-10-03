using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemRize;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {

            VocabManager vocabManager = new VocabManager();
            ToastCreator toastCreator = new ToastCreator();
            TimerService timerService = null;
            VocabStorage vocabStorage = new VocabStorage();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}



        
    