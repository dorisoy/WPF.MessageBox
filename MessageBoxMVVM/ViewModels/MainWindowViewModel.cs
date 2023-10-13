using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Delange.MessageBox;

namespace MessageBoxMVVM.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    public RelayCommand Button1Command { get; private set; }
    public RelayCommand Button2Command { get; private set; }
    public RelayCommand Button3Command { get; private set; }
    public RelayCommand Button4Command { get; private set; }
    public RelayCommand Button5Command { get; private set; }
    public RelayCommand ComplexPathCommand { get; private set; }
    
    /// <summary>
    /// Displays the last MessageBox result
    /// </summary>
    [ObservableProperty]
    private string _dialogResult ="";

    protected IMessageBoxService _messageBox;

    /// <summary>
    /// MessageBox Service 
    /// </summary>
    /// <param name="messageBoxService"></param>
    public MainWindowViewModel(IMessageBoxService messageBoxService)
    {
        _messageBox = messageBoxService;

        Button1Command = new RelayCommand(Button1Click);
        Button2Command = new RelayCommand(Button2Click);
        Button3Command = new RelayCommand(Button3Click);
        Button4Command = new RelayCommand(Button4Click);
        Button5Command = new RelayCommand(Button5Click);
        ComplexPathCommand = new RelayCommand(ExecuteComplexPath);
    }

    private void ExecuteComplexPath()
    {
        var path = ComplexPathWithMessageBoxes();
        _messageBox.Show($"The Path returned {path}");
    }

    /// <summary>
    /// A logical path that involves multiple decisions triggered by MessageBoxes
    /// Test for code coverage (all paths are tested)
    /// </summary>
    /// <returns>the exit path</returns>
    public int ComplexPathWithMessageBoxes()
    {
        Console.WriteLine("Start");
        var res = _messageBox.Show("Please Answer", "MessageBox 1", MessageBoxServiceButton.YesNo);
        Console.WriteLine($"User Clicked {res}");
        if (res == MessageBoxServiceResult.Yes)
        {
            // Yes
            res = _messageBox.Show("Please Answer", "MessageBox 2", MessageBoxServiceButton.Ok);
            Console.WriteLine("OK");
            Console.WriteLine($"User Clicked {res}");
            res = _messageBox.Show("Let's go", "For Sure", MessageBoxServiceButton.YesNo);
            Console.WriteLine($"User Clicked {res}");
            if (res == MessageBoxServiceResult.Yes)
            {
                Console.WriteLine("Yes For sure");
                res = _messageBox.Show("Let's go", "MessageBox 6", MessageBoxServiceButton.OkCancel);
                Console.WriteLine($"User Clicked {res}");
                if (res == MessageBoxServiceResult.OK)
                {
                    return 1;
                }
                else { return 2; }
            }
            else
            {
                res = _messageBox.Show("Let's go", "MessageBox 7", MessageBoxServiceButton.Ok);
                Console.WriteLine($"User Clicked {res}");
                return 3;
            }
        }
        else
        {
            res = _messageBox.Show("Let's go", "MessageBox 3", MessageBoxServiceButton.OkCancel);
            Console.WriteLine($"User Clicked {res}");
            if (res == MessageBoxServiceResult.Cancel)
            {
                return 9;
            }
            else
            {
                res = _messageBox.Show("Let's go", "MessageBox 5", MessageBoxServiceButton.OkCancel);
                Console.WriteLine($"User Clicked {res}");
                if (res == MessageBoxServiceResult.Cancel)
                {
                    res = _messageBox.Show("Let's go", "MessageBox 8", MessageBoxServiceButton.YesNo);
                    Console.WriteLine($"User Clicked {res}");
                    if (res == MessageBoxServiceResult.Yes)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }

                }
                else
                {
                    res = _messageBox.Show("Let's go", "MessageBox 9", MessageBoxServiceButton.YesNoCancel);
                    Console.WriteLine($"User Clicked {res}");
                    switch (res)
                    {
                        case MessageBoxServiceResult.Yes:
                            return 6;
                        case MessageBoxServiceResult.No:
                            return 7;
                        case MessageBoxServiceResult.Cancel:
                        default:
                            return 8;
                    }
                }
            }

        }

    }

    private void Button5Click()
    {
        var res = _messageBox.Show("The application is closing, this might take a few seconds");
        DialogResult = res.ToString();
    }

    private void Button4Click()
    {
        var res = _messageBox.Show("The project has been closed and your Database restored", "Closing", MessageBoxServiceButton.Ok, MessageBoxServiceIcon.Information);
        DialogResult = res.ToString();
    }

    private void Button3Click()
    {
        var res = _messageBox.Show("Hi James, Can I call you Jim?", "Confirm how I call you", MessageBoxServiceButton.YesNo, MessageBoxServiceIcon.Question, MessageBoxServiceResult.No);
        DialogResult = res.ToString();
    }

    private void Button2Click()
    {
        var res = _messageBox.Show("Closing will discard your changes", "Waning closing", MessageBoxServiceButton.OkCancel, MessageBoxServiceIcon.Warning, MessageBoxServiceResult.OK);
        DialogResult = res.ToString();
    }

    private void Button1Click()
    {
        var res = _messageBox.Show("Press Yes to override data, No to discard your changes... \r\n (Press Cancel to go back to input screen)", "Emergency caption of the dialog", MessageBoxServiceButton.YesNoCancel, MessageBoxServiceIcon.Error, MessageBoxServiceResult.Yes);
        DialogResult = res.ToString();
    }
}

