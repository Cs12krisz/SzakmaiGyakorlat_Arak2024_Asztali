using ArakCLI;
using System.IO;
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

namespace ArakWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Program.Beolvasas();
            dtgArak.ItemsSource = Program.arakCollection;
        }

        private void btnTorles_Click(object sender, RoutedEventArgs e)
        {
            if (dtgArak.SelectedIndex != -1)
            {
                Program.arakCollection.RemoveAt(dtgArak.SelectedIndex);
                pbAr.Value = 0;
                lbTermek.Content = "Termék";
                dtgArak.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter("Termekek.txt");
                foreach (var item in Program.arakCollection)
                {
                    streamWriter.WriteLine($"{item.Megnevezes} ==> {((item.Valtozas() > 0) ? $"+{item.Valtozas()}" : item.Valtozas())}");
                }
                streamWriter.Close();
                MessageBox.Show("Sikeres mentés", "Információ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgArak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtgArak.SelectedIndex != -1)
            {
                lbTermek.Content = (dtgArak.SelectedItem as Arak).Megnevezes;
                pbAr.Value = (dtgArak.SelectedItem as Arak).Valtozas();
            }
        }

        private void btnHozzaad_Click(object sender, RoutedEventArgs e)
        {
            HozzaadArak hozzaadArak = new HozzaadArak();
        }

        private void btnModositas_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}