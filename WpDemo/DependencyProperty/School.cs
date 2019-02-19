using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDemo.DependencyProperty
{
    public class School
    {
        public static int GetGrade(DependencyObject obj)
        {
            return (int)obj.GetValue(GradeProperty);
        }

        public static void SetGrade(DependencyObject obj, int value)
        {
            obj.SetValue(GradeProperty, value);
        }

        public static readonly System.Windows.DependencyProperty GradeProperty =
            System.Windows.DependencyProperty.RegisterAttached("Grade", typeof(int), typeof(School), new PropertyMetadata(0));

    }
}
