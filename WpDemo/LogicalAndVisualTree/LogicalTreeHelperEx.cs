using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDemo.LogicalAndVisualTree
{
    static class LogicalTreeHelperEx
    {
        public static T Find<T>(DependencyObject source) where T : DependencyObject
        {
            if (source == null) return null;

            var children = LogicalTreeHelper.GetChildren(source);
            foreach (var child in children)
            {
                if (child != null && child is T)
                {
                    return (T)child;
                }

                var target = Find<T>(child as DependencyObject);
                if (target != null) return target;

            }

            return null;
        }
    }
}
