using System;
using System.Windows.Forms;

namespace cms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and show Form2 (Login)
            Form2 loginForm = new Form2();

            // Show Form2 as a dialog - this will block until Form2 closes
            DialogResult result = loginForm.ShowDialog();

            // If login was successful (DialogResult.OK), run Form1
            if (result == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}