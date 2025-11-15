using Driving_Managment_System;
using System;
using System.Windows.Forms;

namespace DrivingSchoolApp
{
    static class Program
    {
        [STAThread] // Required for Windows Forms apps
        static void Main()
        {
            Application.EnableVisualStyles(); // Use OS visual styles
            Application.SetCompatibleTextRenderingDefault(false); // Use modern text rendering
            Application.Run(new Receptionist()); // Start the application with MainForm
        }
    }
}
