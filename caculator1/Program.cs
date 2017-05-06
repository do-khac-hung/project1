using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.Text;
namespace caculator1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

       

        [STAThread]
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log.Debug("-Debug level-");
            log.Info("Hello, Hung day");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new caculator());
            Console.ReadLine();
        }
        
        }
    }


