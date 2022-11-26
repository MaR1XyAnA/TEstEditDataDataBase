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
using TEstEditDataDataBase.ClassFolder;
using TEstEditDataDataBase.ViewFolder.PageFolder;

namespace TEstEditDataDataBase.ViewFolder.WindowFolder
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameClass.BodyFrame = MainFrame;
            MainFrame.Navigate(new ListPage());
        }
    }
}
