using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Path = System.IO.Path;


namespace Frågesport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int CurrentQ = 0;
        List<Questioncard> frågor = new List<Questioncard>();
        Questioncard q;
        private string filename = "frågor.txt";
        private string pathAndFilename;
        public MainWindow()
        {

           
        InitializeComponent();
            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            pathAndFilename = Path.Combine(docPath, filename);

            ReadFile();


            frågor.Add(new Questioncard("Vad hete Danmarks Huvudstad?", "Köpenhamn"));

            frågor.Add(new Questioncard("Vad heter Norges Huvudstad?", "Oslo"));


            frågor.Add(new Questioncard("Vad hete Finlands Huvudstad?", "Helsingfors"));

            q = frågor[CurrentQ];
            Fråga1.Text = q.question;



        }
         
        private void Svar1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Nästafråga_Click(object sender, RoutedEventArgs e)
        {
            CurrentQ = CurrentQ + 1;
            Fråga1.Text = frågor[CurrentQ].question;
            Svar1.Text = "";
            feedback.Text = "";

        }

        private void Rätta_Click(object sender, RoutedEventArgs e)
        {

            String uans = Svar1.Text;
            if (uans == frågor[CurrentQ].answer)
            {
                feedback.Text = "Rätt";

            }
            else
            {
                feedback.Text = "Fel";
            }
        }
        private void ReadFile()
        {
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(pathAndFilename))
                {
                    string q;
                    string ans;
                   ans = sr.ReadLine();
                    q = sr.ReadLine();
                    while(q != null)
                    {
                        frågor.Add(new Questioncard(ans, q));
                        ans = sr.ReadLine();
                        q = sr.ReadLine();

                    }
                }
            }
            catch (IOException e)
            {
                Fråga1.Text = "The file could not be read:" + e.Message;
            }
        }
        }
}
