using Prism.Unity;
using System;
using System.Collections.Generic;
using MessageBoxUtilities;
using Prism.Ioc;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MessageBoxMVVM.Views;

namespace MessageBoxMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IMessageBoxService, MessageBoxService>();

        }

    }
}
