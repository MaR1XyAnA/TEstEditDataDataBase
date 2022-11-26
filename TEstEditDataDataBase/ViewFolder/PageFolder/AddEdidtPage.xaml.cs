using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TEstEditDataDataBase.AppDataFolder;
using TEstEditDataDataBase.ClassFolder;

namespace TEstEditDataDataBase.ViewFolder.PageFolder
{
    public partial class AddEdidtPage : Page
    {
        public AddEdidtPage(WorkerTable workerTable)
        {
            InitializeComponent();
            AppConnectClass.DataDase = new TestEdditDataEntities();
            if (workerTable != null)
            {
                workerTable = workerTable;
                DataContext = workerTable;
            }
        }

        private void AddEditButton_Click(object sender, RoutedEventArgs e)
        {
            if (SurnameTextBox.Text == "" || nameTextBox.Text == "" || MiddlenameTextBox.Text == "")
            {
                MessageBox.Show("Поля пустые");
            }
            else
            {
                var workerTable = new WorkerTable()
                {
                    SurnameWorker = SurnameTextBox.Text,
                    NameWorker = nameTextBox.Text,
                    MiddlenameWorker = MiddlenameTextBox.Text
                };
                int Id = Convert.ToInt32(IdWorkerTextBlock.Text);
                var rrr = AppConnectClass.DataDase.WorkerTable.Find(Id);
                try
                {
                    if (rrr != null)
                    {
                        AppConnectClass.DataDase.WorkerTable.AddOrUpdate(a => a.IdWorker, workerTable);
                    }
                    

                    AppConnectClass.DataDase.SaveChanges();
                    MessageBox.Show("Сохранено\n" + rrr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.BodyFrame.GoBack();
        }
    }
}
