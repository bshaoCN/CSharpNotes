using Prism.Regions;
using System.Windows;
using Unity;

namespace PrismDemo.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IUnityContainer _container;
        IRegionManager _regionManager;

        public MainWindow(IUnityContainer container, IRegionManager regionManager)
        {
            InitializeComponent();
            _container = container;
            _regionManager = regionManager;

            //this.Loaded += MainWindow_Loaded;

            //_regionManager.RegisterViewWithRegion("ContentRegion", typeof(UserControl1));
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _control1 = _container.Resolve<UserControl1>();
            _control2 = _container.Resolve<UserControl2>();
            _regionManager.Regions["ContentRegion"].Add(_control1);
            _regionManager.Regions["ContentRegion"].Add(_control2);
        }

        private bool flag = true;
        UserControl1 _control1;
        UserControl2 _control2;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                _regionManager.Regions["ContentRegion"].Activate(_control1);

            }
            else
            {
                _regionManager.Regions["ContentRegion"].Activate(_control2);
            }
            flag = !flag;
        }
    }
}
