using System.Windows;

namespace MessageBoxUtilities
{
    public class MessageBoxService : IMessageBoxService
    {

        public MessageBoxService()
        {

        }
        //
        // Summary:
        //     Displays a message box that has a message and that returns a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        public MessageBoxServiceResult Show(string messageBoxText)
        {
            return Show(messageBoxText, "");

        }

        //
        // Summary:
        //     Displays a message box that has a message and title bar caption; and that returns
        //     a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        public MessageBoxServiceResult Show(string messageBoxText, string caption)
        {
            MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText, caption);
            var res = dlg.ShowDialog();
            return MessageBoxServiceResult.OK;
        }

        //
        // Summary:
        //     Displays a message box that has a message, title bar caption, and button; and
        //     that returns a result.
        //
        // Parameters:
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
        //     A  value that specifies which message box button
        //     is clicked by the user.
        public MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button)
        {
            MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText, caption, button);
            var res = dlg.ShowDialog();
            
            return dlg.Result;
        }

        //
        // Summary:
        //     Displays a message box that has a message, title bar caption, button, and icon;
        //     and that returns a result.
        //
        // Parameters:
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
        //     A MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        public MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon)
        {
            MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText, caption, button,icon);
            var res = dlg.ShowDialog();

            return dlg.Result;
        }

        //
        // Summary:
        //     Displays a message box that has a message, title bar caption, button, and icon;
        //     and that accepts a default message box result, complies with the specified options,
        //     and returns a result.
        //
        // Parameters:
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
        public MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon, MessageBoxServiceResult defaultButton)
        {
            MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText, caption, button, icon, defaultButton);
            var res = dlg.ShowDialog();

            return dlg.Result;
        }

        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box displays
        //     a message and returns a result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        public MessageBoxServiceResult Show(Window owner, string messageBoxText)
        {
            MessageBoxDialog dlg = new MessageBoxDialog(messageBoxText);
            dlg.Owner = owner;
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
            dlg.Owner = owner;
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
            dlg.Owner = owner;
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
            dlg.Owner = owner;
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
            dlg.Owner = owner;
            var res = dlg.ShowDialog();

            return dlg.Result;
        }

    }
}
