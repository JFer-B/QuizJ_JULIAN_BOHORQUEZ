using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventParadigmExample
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new LogIn());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string characterName = txtCharacterName.Text;
            string characterGenre = txtCharacterGenre.Text;
            string characterElement = txtElement.SelectedItem.ToString();
            txtResults.Text = txtResults.Text + characterName + "\n" + characterGenre + "\n" + characterElement + "\n";
            if (sldStyle.Value>=0 && sldStyle.Value<40)
            {
                txtResults.Text = txtResults.Text + "Wizard"+"\n"+ "\n";
            }
            else
            {
                if (sldStyle.Value >= 40 && sldStyle.Value < 60)
                {
                    txtResults.Text = txtResults.Text + "Balanced" + "\n" + "\n";
                }
                else
                {
                    txtResults.Text = txtResults.Text + "Fighter" + "\n" + "\n";
                }
            }

            MessageBox.Show("To add new character" + "\n" + "rewrite the values in the boxes");


        }
    }
}
