using System;
using System.Data.Entity.Migrations;
using System.Windows;
using System.Windows.Controls;
using TEstEditDataDataBase.AppDataFolder;
using TEstEditDataDataBase.ClassFolder;

namespace TEstEditDataDataBase.ViewFolder.PageFolder
{
    public partial class AddEdidtPage : Page
    {
        int Id12 = 0;
        public AddEdidtPage(WorkerTable workerTable)
        {
            InitializeComponent();
            AppConnectClass.DataDase = new TestEdditDataEntities();
            if (workerTable != null)
            {
                workerTable = workerTable;
                DataContext = workerTable;
                Id12 = workerTable.IdWorker;
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
                    IdWorker = Id12,
                    SurnameWorker = SurnameTextBox.Text,
                    NameWorker = nameTextBox.Text,
                    MiddlenameWorker = MiddlenameTextBox.Text
                };
                WorkerTable SeartheID = AppConnectClass.DataDase.WorkerTable.Find(Id12);
                try
                {
                    if (SeartheID != null)
                    {
                        AppConnectClass.DataDase.WorkerTable.AddOrUpdate(workerTable);
                    }
                    else
                    {
                        AppConnectClass.DataDase.WorkerTable.Add(workerTable);
                    }
                    AppConnectClass.DataDase.SaveChanges();
                    MessageBox.Show("Сохранено\n");
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
