using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.DirectoryServices.ActiveDirectory;
using System.ComponentModel;

namespace MoveBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ButtonWindow.MainWindow BtnMovingWindow;
        ControlWindow.MainWindow CTWindow;
        public MainWindow()
        {
            InitializeComponent();
            BtnMovingWindow = new ButtonWindow.MainWindow();
            CTWindow = new ControlWindow.MainWindow(BtnMovingWindow);
            CTWindow.Closing += new CancelEventHandler(MainWindow_Closing);
            this.Hide();
            CTWindow.Show();
            BtnMovingWindow.Show();
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            if(BtnMovingWindow != null)
            {
                BtnMovingWindow.Close();
            }
            Application.Current.MainWindow.Close();
        }
    }
}
