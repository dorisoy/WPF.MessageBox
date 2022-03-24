using MessageBoxUtilities;
using Prism.Commands;
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
        public DelegateCommand Button1Command { get; private set; }
        public DelegateCommand Button2Command { get; private set; }
        public DelegateCommand Button3Command { get; private set; }
        public DelegateCommand Button4Command { get; private set; }
        public DelegateCommand Button5Command { get; private set; }

        private string _dialogResult;
        public string DialogResult { get { return _dialogResult; } private set { SetProperty(ref _dialogResult, value); } }



        protected IMessageBoxService _messageBox;

        public MainWindowViewModel(IMessageBoxService messageBoxService)
        {
            _messageBox = messageBoxService;

            Button1Command = new DelegateCommand(Button1Click);
            Button2Command = new DelegateCommand(Button2Click);
            Button3Command = new DelegateCommand(Button3Click);
            Button4Command = new DelegateCommand(Button4Click);
            Button5Command = new DelegateCommand(Button5Click);
        }

        private void Button5Click()
        {
            var res = _messageBox.Show("Just a Message but a very long message that should go over 2 lines long or more, may be");
            DialogResult = res.ToString();
        }

        private void Button4Click()
        {
            var res = _messageBox.Show("A Message should appear here", "Caption of the dialog", MessageBoxServiceButton.OkCancel, MessageBoxServiceIcon.Information);
            DialogResult = res.ToString();
        }

        private void Button3Click()
        {
            var res = _messageBox.Show("A Message should appear here", "Caption of the dialog", MessageBoxServiceButton.YesNo, MessageBoxServiceIcon.Question, MessageBoxServiceResult.No);
            DialogResult = res.ToString();
        }

        private void Button2Click()
        {
            var res = _messageBox.Show("An Emergency Message should appear hereand is very long", "Emergency caption of the dialog", MessageBoxServiceButton.YesNo, MessageBoxServiceIcon.Warning, MessageBoxServiceResult.Yes);
            DialogResult = res.ToString();
        }

        private void Button1Click()
        {
            var res = _messageBox.Show("An Emergency Message should appear hereand is very long", "Emergency caption of the dialog", MessageBoxServiceButton.YesNoCancel, MessageBoxServiceIcon.Error, MessageBoxServiceResult.Yes);
            DialogResult = res.ToString();
        }
    }
}
