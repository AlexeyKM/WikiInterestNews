using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using WikiInterestNews.Models;

namespace WikiInterestNews
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        long maxid = 6000000001;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            random = new Random();
            int id = random.Next(1000000, 1100000);
            Artical artical = LoadArtical.LoadArticalsTitle().Result; 
            if (artical.Extract != null)
            {
                // Используйте текст статьи в вашем приложении
                textbox.Text = artical.Extract.ToString();
            }


        }
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textbox.FontSize = textbox.FontSize + 5;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textbox.FontSize >= 5)
            {
                textbox.FontSize = textbox.FontSize - 5;
            }

        }

    }
}
