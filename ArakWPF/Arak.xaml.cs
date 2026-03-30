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
using System.Windows.Shapes;

namespace ArakWPF
{
    /// <summary>
    /// Interaction logic for Arak.xaml
    /// </summary>
    public partial class Arak : Window
    {
        Arak? JelenlegArak { get; set; } = null;
        public Arak(Arak jelenlegArak)
        {
            InitializeComponent();
            JelenlegArak = jelenlegArak;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (JelenlegArak != null)
            {
                
            }
        }
    }
}
