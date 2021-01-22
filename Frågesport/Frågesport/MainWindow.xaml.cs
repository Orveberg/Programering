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
        public MainWindow()
        {
            InitializeComponent();

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
    }
}
