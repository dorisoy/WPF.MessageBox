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

namespace MessageBoxUtilities
{
    /// <summary>
    /// Interaction logic for MessageBox.xaml
    /// </summary>
    public partial class MessageBoxDialog : Window
    {
        private MessageBoxServiceResult _result;
        public MessageBoxServiceResult Result { get => _result; }
        public MessageBoxDialog(string message, string header="",MessageBoxServiceButton buttons = MessageBoxServiceButton.Ok, MessageBoxServiceIcon icon=MessageBoxServiceIcon.None,MessageBoxServiceResult defaultButton = MessageBoxServiceResult.OK)
        {
            InitializeComponent();
            MessageText.Text = message;
            Title = header;
            switch(icon)
            {
                case MessageBoxServiceIcon.Information:
                    InformationIcon.Visibility = Visibility.Visible;
                    break;
                    case MessageBoxServiceIcon.Warning:
                    WarningIcon.Visibility = Visibility.Visible;
                    break;
                case MessageBoxServiceIcon.Error:
                    CriticalIcon.Visibility = Visibility.Visible;
                    break;
                case MessageBoxServiceIcon.Question:
                    QuestionIcon.Visibility = Visibility.Visible;   
                    break;
                case MessageBoxServiceIcon.None:
                default:
                    break;
            }
            switch(buttons)
            {
                case MessageBoxServiceButton.OkCancel:
                    OkButton.Visibility = Visibility.Visible;
                    CancelButton.Visibility = Visibility.Visible;
                    CancelButton.IsCancel = true;
                    break;
                case MessageBoxServiceButton.YesNo:
                    YesButton.Visibility = Visibility.Visible;
                    NoButton.Visibility = Visibility.Visible;
                    break;
                case MessageBoxServiceButton.YesNoCancel:
                    YesButton.Visibility= Visibility.Visible;
                    NoButton.Visibility =   Visibility.Visible;
                    CancelButton.Visibility= Visibility.Visible;
                    CancelButton.IsCancel= true;
                    break;
                case MessageBoxServiceButton.Ok:
                default:
                    OkButton.Visibility = Visibility.Visible;
                    break;
            }
            switch(defaultButton)
            {
                case MessageBoxServiceResult.Cancel:
                    CancelButton.IsDefault = true;
                    break;
                case MessageBoxServiceResult.Yes:
                    YesButton.IsDefault= true;
                    break;
                case MessageBoxServiceResult.No:
                    NoButton.IsDefault= true;
                    break;
                case MessageBoxServiceResult.OK:
                    break;           
            }
        }

        private void OKClicked(object sender, RoutedEventArgs e)
        {
                _result = MessageBoxServiceResult.OK;
        }

        private void CancelClicked(object sender, RoutedEventArgs e)
        {
            _result= MessageBoxServiceResult.Cancel;
        }

        private void YesClicked(object sender, RoutedEventArgs e)
        {
            _result = MessageBoxServiceResult.Yes;
        }

        private void NoClicked(object sender, RoutedEventArgs e)
        {
            _result=MessageBoxServiceResult.No;
        }
    }
    public enum MessageBoxServiceIcon
    {
        None,
        Error,
        Warning,
        Information,
        Question
    }

    public enum MessageBoxServiceButton
    {
        Ok,
        OkCancel,
        YesNo,
        YesNoCancel
    }
    public enum MessageBoxServiceResult
    {
        OK,
        Cancel,
        Yes,
        No 
    }
}
