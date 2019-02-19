using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDemo.DependencyProperty
{
    public class Student : DependencyObject
    {
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public static readonly System.Windows.DependencyProperty NameProperty =
            System.Windows.DependencyProperty.Register("Name", typeof(string), typeof(Student), new PropertyMetadata(string.Empty, new PropertyChangedCallback(OnNamePropertyChanged), new CoerceValueCallback(OnCoerceNameProperty)), new ValidateValueCallback(OnValidNameProperty));

        private static bool OnValidNameProperty(object value)
        {
            return value is string;
        }

        private static object OnCoerceNameProperty(DependencyObject d, object baseValue)
        {
            if (baseValue.ToString().Length > 5)
                baseValue = string.Empty;
            return baseValue;
        }

        private static void OnNamePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //MessageBox.Show(e.NewValue.ToString());
        }
    }
}
