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
using System.Windows.Shapes;

namespace SAS.Task._5f.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Task1Page _task1Page1 = new();
        public Window1(Task1Page task1Page)
        {
            InitializeComponent();

            task1Page = _task1Page1;

            task1Page.HelloWindow();
        }
    }
}
