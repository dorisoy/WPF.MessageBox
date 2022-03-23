using MessageBoxUtilities;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialog.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        protected IMessageBoxService _messageBox;
        public MainWindowViewModel()
        {

        }

        public MainWindowViewModel(IMessageBoxService messageBoxService)
        {
            _messageBox = messageBoxService;
        }
    }
}
