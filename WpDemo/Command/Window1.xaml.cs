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
using System.Windows.Shapes;

namespace WpfDemo.Command
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DataContext = this;
        }

        private DelegateCommand clickCommand;
        public DelegateCommand ClickCommand
        {
            get
            {
                if (clickCommand == null)
                {
                    clickCommand = new DelegateCommand(() => MessageBox.Show("Click"));
                }
                return clickCommand;
            }
        }

        private DelegateCommand<string> clickCommand2;
        public DelegateCommand<string> ClickCommand2
        {
            get
            {
                if (clickCommand2 == null)
                {
                    clickCommand2 = new DelegateCommand<string>((s) => MessageBox.Show(s));
                }
                return clickCommand2;
            }
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = txt2 != null && txt2.SelectedText.Length > 0;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //Clipboard.SetText("Custom RoutedCommand" + txt2.SelectedText);
            MessageBox.Show("Custom RoutedCommand:" + txt2.SelectedText);
        }

        private void CommandBinding_Executed2(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Custom RoutedCommand2:" + txt2.SelectedText);
        }
    }
}
