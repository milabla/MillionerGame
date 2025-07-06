using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillionaireGame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             //Application.Run(new Form1());
             // Initialize an empty list of questions or load them from somewhere
             List<Question> questions = new List<Question>();
             // Create an instance of Form2, passing the initialized questions list
             Application.Run(new Form2(questions)); // Form2 mi e startna forma
           */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Initialize Form1 (if needed)
            form1.InitializeGame(); // Ensure questions are initialized

            // Get questions from Form1
            List<Question> questions = form1.GetQuestions();

            // Create and run Form2 with the questions
            Application.Run(new Form2(questions)); // Pass the questions to Form2
        }
    }
}
