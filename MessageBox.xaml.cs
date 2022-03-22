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

namespace Utilities
{
    /// <summary>
    /// Interaction logic for MessageBox.xaml
    /// </summary>
    public partial class MessageBox : Window
    {
        public MessageBox()
        {
            InitializeComponent();
        }
    }
    public enum MessageBoxType
    {
        Critical,
        Warning,
        Information,
        Question
    }

    public enum MessageBoxButtons
    {
        Ok,
        Cancel,
        OkCancel,
        YesNo,
        YesNoCancel
    }
}
