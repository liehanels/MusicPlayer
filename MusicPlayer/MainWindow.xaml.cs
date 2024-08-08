using Microsoft.VisualBasic;
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

namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CDList list = new CDList();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddMusic_Click(object sender, RoutedEventArgs e)
        {
            string song = Interaction.InputBox("Add a song name", "Add Song");
            list.AddToEnd(song);
        }

        private void btnPlayPause_Click(object sender, RoutedEventArgs e)
        {
            txtSongName.Text = list.getSong();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            txtSongName.Text = list.getSong("next");
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            txtSongName.Text = list.getSong("prev");
        }
    }
}