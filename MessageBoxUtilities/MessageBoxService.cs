using System.Windows;

namespace Delange.MessageBox;

public class MessageBoxService : IMessageBoxService
{

    public MessageBoxService()
    {

    }
    /// <summary>
    /// Display a simple MessageBox with a OK button
    /// </summary>
    /// <param name="messageBoxText">Message to Display</param>
    /// <returns>MessageBoxServiceResult.OK</returns>
    public MessageBoxServiceResult Show(string messageBoxText)
    {
        return Show(messageBoxText, "");

    }


    /// <summary>
    /// Display a simple MessageBox with a OK button
    /// </summary>
    /// <param name="messageBoxText">Message to Display</param>
    /// <param name="caption">Caption in the title Bar</param>
    /// <returns>MessageBoxServiceResult.OK</returns>
    public MessageBoxServiceResult Show(string messageBoxText, string caption)
    {
        MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText, caption);
        var res = dlg.ShowDialog();
        return MessageBoxServiceResult.OK;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="messageBoxText">Message to Display</param>
    /// <param name="caption">Caption in the title Bar</param>
    /// <param name="button">MessageBoxServiceButton OK, OKCancel, YesNo, YesNoCancel</param>
    /// <returns>Which button was clicked</returns>
    public MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button)
    {
        MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText, caption, button);
        var res = dlg.ShowDialog();    
        return dlg.Result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="messageBoxText">Message to Display</param>
    /// <param name="caption">Caption in the title Bar</param>
    /// <param name="button">MessageBoxServiceButton OK, OKCancel, YesNo, YesNoCancel</param>
    /// <param name="icon">Dialog Left side image: None, Error, Warning, Info, Question</param>
    /// <returns>Which button was clicked</returns>
    public MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon)
    {
        MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText, caption, button,icon);
        var res = dlg.ShowDialog();
        return dlg.Result;
    }


    /// <summary>
    ///    Displays a message box that has a message, title bar caption, button, and icon;
    ///     and that accepts a default message box result, complies with the specified options,
    ///     and returns a result.
    /// </summary>
    /// <param name="messageBoxText">Message to Display</param>
    /// <param name="caption">Caption in the title Bar</param>
    /// <param name="button">MessageBoxServiceButton OK, OKCancel, YesNo, YesNoCancel</param>
    /// <param name="icon">Dialog Left side image: None, Error, Warning, Info, Question</param>
    /// <param name="defaultButton">Button that will respond to ther enter key and will display as default</param>
    /// <returns></returns>
    public MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon, MessageBoxServiceResult defaultButton)
    {
        MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText, caption, button, icon, defaultButton);

        var res = dlg.ShowDialog();

        return dlg.Result;
    }



    /// <summary>
    /// Displays a message box in front of the specified window. The message box displays
    /// a message and returns a result.
    /// </summary>
    /// <param name="owner">The window below the dialog</param>
    /// <param name="messageBoxText"></param>
    /// <returns>A value that specifies which message box button is clicked by the user.</returns>
    public MessageBoxServiceResult Show(Window owner, string messageBoxText)
    {
        MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText);
        if (owner != null)
        {
            dlg.Owner = owner;
            dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }
        dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var res = dlg.ShowDialog();

        return dlg.Result;
    }

    //
    // Summary:
    //     Displays a message box in front of the specified window. The message box displays
    //     a message and title bar caption; and it returns a result.
    //
    // Parameters:
    //   owner:
    //     A System.Windows.Window that represents the owner window of the message box.
    //
    //   messageBoxText:
    //     A System.String that specifies the text to display.
    //
    //   caption:
    //     A System.String that specifies the title bar caption to display.
    //
    // Returns:
    //     A System.Windows.MessageBoxResult value that specifies which message box button
    //     is clicked by the user.
    public MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption)
    {
        MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText,caption);
        if (owner != null)
        {
            dlg.Owner = owner;
            dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }
        dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var res = dlg.ShowDialog();

        return dlg.Result;
    }

    //
    // Summary:
    //     Displays a message box in front of the specified window. The message box displays
    //     a message, title bar caption, and button; and it also returns a result.
    //
    // Parameters:
    //   owner:
    //     A System.Windows.Window that represents the owner window of the message box.
    //
    //   messageBoxText:
    //     A System.String that specifies the text to display.
    //
    //   caption:
    //     A System.String that specifies the title bar caption to display.
    //
    //   button:
    //     A System.Windows.MessageBoxButton value that specifies which button or buttons
    //     to display.
    //
    // Returns:
    //     A System.Windows.MessageBoxResult value that specifies which message box button
    //     is clicked by the user.
    public MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption, MessageBoxServiceButton button)
    {
        MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText,caption,button);
        if (owner != null)
        {
            dlg.Owner = owner;
            dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }
        dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var res = dlg.ShowDialog();

        return dlg.Result;
    }

    //
    // Summary:
    //     Displays a message box in front of the specified window. The message box displays
    //     a message, title bar caption, button, and icon; and it also returns a result.
    //
    // Parameters:
    //   owner:
    //     A System.Windows.Window that represents the owner window of the message box.
    //
    //   messageBoxText:
    //     A System.String that specifies the text to display.
    //
    //   caption:
    //     A System.String that specifies the title bar caption to display.
    //
    //   button:
    //     A System.Windows.MessageBoxButton value that specifies which button or buttons
    //     to display.
    //
    //   icon:
    //     A System.Windows.MessageBoxImage value that specifies the icon to display.
    //
    // Returns:
    //     A System.Windows.MessageBoxResult value that specifies which message box button
    //     is clicked by the user.
    public MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon)
    {
        MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText,caption,button,icon);
        if (owner != null)
        {
            dlg.Owner = owner;
            dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }
        dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var res = dlg.ShowDialog();

        return dlg.Result;
    }

    //
    // Summary:
    //     Displays a message box in front of the specified window. The message box displays
    //     a message, title bar caption, button, and icon; and accepts a default message
    //     box result and returns a result.
    //
    // Parameters:
    //   owner:
    //     A System.Windows.Window that represents the owner window of the message box.
    //
    //   messageBoxText:
    //     A System.String that specifies the text to display.
    //
    //   caption:
    //     A System.String that specifies the title bar caption to display.
    //
    //   button:
    //     A System.Windows.MessageBoxButton value that specifies which button or buttons
    //     to display.
    //
    //   icon:
    //     A System.Windows.MessageBoxImage value that specifies the icon to display.
    //
    //   defaultResult:
    //     A System.Windows.MessageBoxResult value that specifies the default result of
    //     the message box.
    //
    // Returns:
    //     A System.Windows.MessageBoxResult value that specifies which message box button
    //     is clicked by the user.
    public MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon, MessageBoxServiceResult defaultButton)
    {
        MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText, caption, button, icon, defaultButton);
        if (owner != null)
        {
            dlg.Owner = owner;
            dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }
        dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var res = dlg.ShowDialog();

        return dlg.Result;
    }

}
