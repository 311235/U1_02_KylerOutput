﻿/* 
 * Kyler Campbell
 * Deb 8, 2018
 * Output
 * User types a name and age and it outputs hello "name" your age is "age"
*/

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

namespace u1_02_ColinOutput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            String input = Console.ReadLine();
            Console.WriteLine(input);
            Console.Read();
        }

        private void btnshowgreeting_Click(object sender, RoutedEventArgs e)
        {
            lbloutput.Content = "hello, " + entryname.Text + "So, I see that your age is " + Slider.Value; 
        }
    }
}



