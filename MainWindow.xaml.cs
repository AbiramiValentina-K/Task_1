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

namespace Task_1
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

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            String a = TextBox1.Text;
            char[] atochar = a.ToCharArray();
            Array.Reverse(atochar);
            String rev = new string(atochar);
            TextBox2.Text = rev;
        }

        private void TextBox1_keyDown(object sender, KeyEventArgs e)
        {
            Label.Content = e.Key;

        }

        //public void TextBox1_keyDown(object sender, KeyEventArgs e)
        //{
        //    Label.Content = e.KeyboardDevice;

        //}
        //private void TextBox1_keyDown(object sender, KeyEventArgs f)
        //{
        //    Label.Content = $"Key pressed: {f.KeyboardDevice}";
        //}
    }
}
