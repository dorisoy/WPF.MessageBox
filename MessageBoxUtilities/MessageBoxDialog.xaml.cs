using System.Windows;

namespace Delange.MessageBox;

/// <summary>
/// Interaction logic for MessageBoxDialog.xaml
/// </summary>
public partial class MessageBoxDialog : Window
{

    private MessageBoxServiceResult _result = MessageBoxServiceResult.None;
    public MessageBoxServiceResult Result { get => _result; }

    public MessageBoxDialog(string message, string header = "", MessageBoxServiceButton buttons = MessageBoxServiceButton.Ok, MessageBoxServiceIcon icon = MessageBoxServiceIcon.None, MessageBoxServiceResult defaultButton = MessageBoxServiceResult.OK)
    {
        InitializeComponent();
        MessageText.Text = message;
        Title = header;
        _result = MessageBoxServiceResult.None;
        switch (icon)
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
        switch (buttons)
        {
            case MessageBoxServiceButton.OkCancel:
                OkButton.Visibility = Visibility.Visible;
                CancelButton.Visibility = Visibility.Visible;
                CancelButton.IsCancel = true;
                break;
            case MessageBoxServiceButton.YesNo:
                YesButton.Visibility = Visibility.Visible;
                YesButton.IsDefault = true;
                OkButton.IsDefault = false;
                NoButton.Visibility = Visibility.Visible;
                NoButton.IsCancel = true;
                break;
            case MessageBoxServiceButton.YesNoCancel:
                YesButton.Visibility = Visibility.Visible;
                YesButton.IsDefault = true;
                OkButton.IsDefault = false;
                NoButton.Visibility = Visibility.Visible;
                CancelButton.Visibility = Visibility.Visible;
                CancelButton.IsCancel = true;
                break;
            case MessageBoxServiceButton.Ok:
            default:
                OkButton.Visibility = Visibility.Visible;
                break;
        }
        switch (defaultButton)
        {
            case MessageBoxServiceResult.Cancel:
                CancelButton.IsDefault = true;
                break;
            case MessageBoxServiceResult.Yes:
                YesButton.IsDefault = true;
                break;
            case MessageBoxServiceResult.No:
                NoButton.IsDefault = true;
                break;
            case MessageBoxServiceResult.OK:
                OkButton.IsDefault = true;
                break;
        }
        if (Application.Current.MainWindow != null)
        {
            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }
    }

    private void OKClicked(object sender, RoutedEventArgs e)
    {
        _result = MessageBoxServiceResult.OK;
        DialogResult = true;
    }

    private void CancelClicked(object sender, RoutedEventArgs e)
    {
        _result = MessageBoxServiceResult.Cancel;
        DialogResult = true;
    }

    private void YesClicked(object sender, RoutedEventArgs e)
    {
        _result = MessageBoxServiceResult.Yes;
        DialogResult = true;
    }

    private void NoClicked(object sender, RoutedEventArgs e)
    {
        _result = MessageBoxServiceResult.No;
        DialogResult = true;
    }

    /// <summary>
    /// MessageBox is closed - Handle cases when the close button is clicked and doesn't register as cancel
    /// </summary>
    /// <param name="e"></param>
    protected override void OnClosed(EventArgs e)
    {
        base.OnClosed(e);
        if (DialogResult != true) // No button Registered
        {
            // Handles when the user click the close button (right top corner)

            // If the cancel Button is visible on the MessageBox the close button should have the same effect
            if (_result == MessageBoxServiceResult.None && (CancelButton.Visibility == Visibility.Visible))
            {
                _result = MessageBoxServiceResult.Cancel;
            }
            else
            {
                // If a Button is assigned to canceling the form 
                // Set the result to that button
                if (_result == MessageBoxServiceResult.None)
                {
                    if (YesButton.IsCancel)
                    {
                        _result = MessageBoxServiceResult.Yes;
                    }
                    if (NoButton.IsCancel)
                    {
                        _result = MessageBoxServiceResult.No;
                    }
                }
            }
        }
    }
}
