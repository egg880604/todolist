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

namespace todolist
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

            // 產生一個方塊
            Todoitem item = new Todoitem();

            // 放到 Todostack
            TodoStack.Children.Add(item);
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void SaveBtn_Click_1(object sender, RoutedEventArgs e)
        {
            List<string> all = new List<string>();

            // 取得每一個 item 的文字
            foreach (Todoitem item in TodoStack.Children)
            {
                all.Add(item.GeTaskName());
            }

            // 寫入檔案
            System.IO.File.WriteAllLines(@"c:\tododata.txt", all);
        }
    }
}


        