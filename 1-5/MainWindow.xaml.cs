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
using static _1_5.Classes.ClassHelper;
using _1_5.Classes;

namespace _1_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CmbGender.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbFName.Text))
            {
                MessageBox.Show("Заполните поле с именем");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbLName.Text))
            {
                MessageBox.Show("Заполните поле с фамилией");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbMName.Text))
            {
                MessageBox.Show("Заполните поле с отчеством");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbMail.Text))
            {
                MessageBox.Show("Заполните поле с почтой");
                return;
            }
            bool result = int.TryParse(TbPhone.Text, out var num);
            if (result!= true||Convert.ToInt32(TbPhone.Text)<0)
            {
                MessageBox.Show("Заполните поле с телефоном правильно");
                return;
            }
            else
            {
                Employee employee = new Employee();
                employee.firstname = TbFName.Text;
                employee.lastname = TbLName.Text;
                employee.midlename = TbMName.Text;
                employee.phone = Convert.ToInt32(TbPhone.Text);
                employee.email = TbMail.Text;
                employee.gender = CmbGender.SelectedItem.ToString();
                employees.Add(employee);
                MessageBox.Show(employee.firstname+"\n"+ employee.lastname + "\n" + employee.midlename + "\n" + employee.phone + "\n" + employee.email + "\n" + employee.gender + "\n");

            }
            
        }
    }
}
