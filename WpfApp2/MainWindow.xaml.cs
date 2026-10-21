using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal celkovacena = 0;
        public MainWindow()
        {
            InitializeComponent();
            NovyNakup();
        }
        private void Vypis(string nazov, decimal cena)
        {
            block_txt.Text += nazov+ "   " + cena + "€" + System.Environment.NewLine;
            celkovacena += cena;
            celkovacena_txt.Content = "CELKOVÁ SUMA: " + celkovacena + "   €";

        }
        private void NovyNakup()
        {
            block_txt.Text = "------------- Bločik -------------";
            celkovacena = 0;
            celkovacena_txt.Content = "CELKOVÁ SUMA" + celkovacena + "  €";

        }


        private void kukla_btn_Click(object sender, RoutedEventArgs e)
        {
            Vypis("kukla", 2m);
        }

        private void jedlo_btn_Click(object sender, RoutedEventArgs e)
        {
            Vypis("jedlo", 10m);
        }

        private void jazda_btn_Click(object sender, RoutedEventArgs e)
        {
            Vypis("jazda", 15m);
        }

        private void magnetka_btn_Click(object sender, RoutedEventArgs e)
        {
            Vypis("magnetka", 5m);
        }

        private void kofola_btn_Click(object sender, RoutedEventArgs e)
        {
            Vypis("kofola", 2m);
        }

        private void prenajom_btn_Click(object sender, RoutedEventArgs e)
        {
            Vypis("1hod prenajom", 120m);
        }

        private void novynakup_btn_Click(object sender, RoutedEventArgs e)
        {
            Vypis("Celkovacena", 0m);
            NovyNakup();
            
        }
    }
}