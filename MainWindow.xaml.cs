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
using practika.bankDataSetTableAdapters;

namespace practika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        operTableAdapter oper = new operTableAdapter();
        oper1TableAdapter oper1 = new oper1TableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            ColourDataGrid.ItemsSource = oper1.GetData();
            ColourComboBox.ItemsSource = oper.GetData();
            ColourComboBox.DisplayMemberPath = "mas_name";
        }

    }
}
