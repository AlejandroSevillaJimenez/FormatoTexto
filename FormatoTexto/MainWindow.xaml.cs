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

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FormateadoTextBlock.Text = TextoTextBox.Text;
        }

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            FormateadoTextBlock.FontWeight = FontWeights.Bold;
        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            FormateadoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            FormateadoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            FormateadoTextBlock.FontStyle = FontStyles.Normal;
        }

        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            FormateadoTextBlock.Foreground = Brushes.Blue;
        }

        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            FormateadoTextBlock.Foreground = Brushes.Red;
        }

        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            FormateadoTextBlock.Foreground = Brushes.Green;
        }
    }
}
