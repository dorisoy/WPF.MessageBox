using System.Windows;

namespace MessageBoxUtilities
{
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
        /// <param name="defaultButton">Button that will respond to the enter key and will display as default</param>
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
        /// <param name="messageBoxText">Message to Display</param>
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

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message and returns a result.
        /// </summary>
        /// <param name="owner">The window below the dialog</param>
        /// <param name="messageBoxText">Message to Display</param>
        /// <param name="caption">Caption in the title Bar</param>
        /// <returns></returns>
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

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message and returns a result.
        /// </summary>
        /// <param name="owner">The window below the dialog</param>
        /// <param name="messageBoxText">Message to Display</param>
        /// <param name="caption">Caption in the title Bar</param>
        /// <param name="button">MessageBoxServiceButton OK, OKCancel, YesNo, YesNoCancel</param>
        /// <returns>A value that specifies which message box button is clicked by the user.</returns>
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

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message and returns a result.
        /// </summary>
        /// <param name="owner">The window below the dialog</param>
        /// <param name="messageBoxText">Message to Display</param>
        /// <param name="caption">Caption in the title Bar</param>
        /// <param name="button">MessageBoxServiceButton OK, OKCancel, YesNo, YesNoCancel</param>
        /// <param name="icon">Dialog Left side image: None, Error, Warning, Info, Question</param>
        /// <returns>A value that specifies which message box button is clicked by the user.</returns>
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

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message and returns a result.
        /// </summary>
        /// <param name="owner">The window below the dialog</param>
        /// <param name="messageBoxText">Message to Display</param>
        /// <param name="caption">Caption in the title Bar</param>
        /// <param name="button">MessageBoxServiceButton OK, OKCancel, YesNo, YesNoCancel</param>
        /// <param name="icon">Dialog Left side image: None, Error, Warning, Info, Question</param>
        /// <param name="defaultButton">Button that will respond to the enter key and will display as default</param>
        /// <returns>A value that specifies which message box button is clicked by the user.</returns>
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
}
