using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpDemo.DependencyProperty
{
    public class Student : DependencyObject
    {
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public static readonly System.Windows.DependencyProperty NameProperty =
            System.Windows.DependencyProperty.Register("Name", typeof(string), typeof(Student), new PropertyMetadata(new PropertyChangedCallback(OnNameChanged)));

        private static void OnNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            int i;
            i= 1;
        }
    }
}
