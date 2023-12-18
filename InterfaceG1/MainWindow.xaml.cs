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

namespace InterfaceG1
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

        private void ok_btn_Click(object sender, RoutedEventArgs e)
        {
            if (IsValid())
            {
                hello_display_lab.Content = $"{fname_tb.Text} {name_tb.Text} {clacAge()} ans";
                hello_display_lab.Visibility = Visibility.Visible;
            } else
            {
                MessageBox.Show("Erreur: veuillez compléter les champs");
            }
        }

        private void del_button_Click(object sender, RoutedEventArgs e)
        {
            name_tb.Clear();
            fname_tb.Clear();
            birth_picker.Text = string.Empty;
            hello_display_lab.Visibility = Visibility.Hidden;
        }

        private int clacAge()
        {
            return DateTime.Now.Year - DateTime.Parse(birth_picker.Text).Year; 
        }

        private bool IsValid()
        {
            return name_tb.Text != "" && fname_tb.Text != "" && birth_picker.Text != "";
        }
    }
}