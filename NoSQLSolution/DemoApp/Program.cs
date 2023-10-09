using Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // tijdelijke employee
            Employee employee = new Employee(ObjectId.Parse("6523b6d07171c0f1c35705f8"), 1, "Jfreese@gardengroup.nl", "Jaap", "Freese", "JFreese", "1b4f0e9851971998e732078544c96b36c3d01cedf7caa332359d6f1d83567014", UserType.RegularUser);
            Application.Run(new TicketOverviewForm(employee));
        }
    }
}
