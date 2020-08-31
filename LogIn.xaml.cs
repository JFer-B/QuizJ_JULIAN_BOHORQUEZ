using System;
using System.Collections.Generic;
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

namespace EventParadigmExample
{
    /// <summary>
    /// Lógica de interacción para LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogIn_Click_1(object sender, RoutedEventArgs e)
        {
            if(txtUsername.Text=="JFerk" && txtPassword.Password=="1234")
            {
                MainWindow w = (MainWindow) Window.GetWindow(this);
                w.frameMain.NavigationService.Navigate(new Home());
            }
            else
            {
                MessageBox.Show("Error: Inavlid crediantials.");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}
