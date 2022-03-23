using System.Windows;

namespace MessageBoxUtilities
{
    public interface IMessageBoxService
    {
        MessageBoxServiceResult Show(string messageBoxText);
        MessageBoxServiceResult Show(string messageBoxText, string caption);
        MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button);
        MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon);
        MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon, MessageBoxServiceResult defaultResult);
        MessageBoxServiceResult Show(Window owner, string messageBoxText);
        MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption);
        MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption, MessageBoxServiceButton button);
        MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon);
        MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon, MessageBoxServiceResult defaultResult);
    }
}