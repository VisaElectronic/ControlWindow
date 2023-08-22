using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ControlWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window window;
        public MainWindow(Window targetWindow)
        {
            window = targetWindow;
            InitializeComponent();
        }

        private void MoveUp(object sender, EventArgs e)
        {
            var moveUp = window.GetType().GetMethod("MoveUp");
            if(moveUp != null)
            {
                moveUp.Invoke(window, new object[0]);
            }
        }
        private void MoveRight(object sender, EventArgs e)
        {
            var moveUp = window.GetType().GetMethod("MoveRight");
            if (moveUp != null)
            {
                moveUp.Invoke(window, new object[0]);
            }
        }
        private void MoveLeft(object sender, EventArgs e)
        {
            var moveUp = window.GetType().GetMethod("MoveLeft");
            if (moveUp != null)
            {
                moveUp.Invoke(window, new object[0]);
            }
        }
        private void MoveDown(object sender, EventArgs e)
        {
            var moveUp = window.GetType().GetMethod("MoveDown");
            if (moveUp != null)
            {
                moveUp.Invoke(window, new object[0]);
            }
        }
    }
}
