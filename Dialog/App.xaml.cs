using Dialog.Views;
using MessageBoxUtilities;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Windows;

namespace Dialog
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
