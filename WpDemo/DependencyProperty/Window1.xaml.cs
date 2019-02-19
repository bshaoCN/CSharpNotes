using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfDemo.LogicalAndVisualTree;

namespace WpfDemo.DependencyProperty
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Student Student;
        public Window1()
        {
            InitializeComponent();

            BindingDP();
            ListenDP();
            SetAP();

        }

        private void ListenDP()
        {
            // Listen to dependency property changes
            DependencyPropertyDescriptor dpDesc = DependencyPropertyDescriptor.FromProperty(Student.NameProperty, typeof(Student));
            if (dpDesc != null)
            {
                dpDesc.AddValueChanged(Student, (sender, e) =>
                {
                    Console.WriteLine(sender.GetType());
                    Console.WriteLine();
                });
            }
        }

        private void BindingDP()
        {
            Student = new Student();
            BindingOperations.SetBinding(Student, Student.NameProperty,
                new Binding("Text") { Source = name1, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });
            name2.SetBinding(TextBox.TextProperty,
                new Binding("Name") { Source = Student, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });
        }


        private void SetAP()
        {
            School.SetGrade(Student, 10);
            Console.WriteLine(School.GetGrade(Student));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
