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
using TEstEditDataDataBase.AppDataFolder;
using TEstEditDataDataBase.ClassFolder;

namespace TEstEditDataDataBase.ViewFolder.PageFolder
{
    public partial class ListPage : Page
    {
        public ListPage()
        {
            InitializeComponent();
            AppConnectClass.DataDase = new TestEdditDataEntities();
            ListWorkwrListBox.ItemsSource = AppConnectClass.DataDase.WorkerTable.ToList();
        }

        private void ListWorkwrListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var EdditWorker = ListWorkwrListBox.SelectedItem as WorkerTable;
            FrameClass.BodyFrame.Navigate(new AddEdidtPage(EdditWorker));
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.BodyFrame.Navigate(new AddEdidtPage(null));
        }
    }
}
