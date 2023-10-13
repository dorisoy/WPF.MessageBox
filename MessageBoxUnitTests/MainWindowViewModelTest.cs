using Delange.MessageBox;
using MessageBoxMVVM.ViewModels;
using System.Windows;

namespace MessageBoxUnitTests
{
    public class MainWindowViewModelTest
    {


        [Fact]
        public void TestComplexPathWithMessageBoxes_Command()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Yes);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Yes);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            vm.ComplexPathCommand.Execute(null);
            var ret = mbe.LastReturn;
            Assert.True(ret == MessageBoxServiceResult.OK, "This Path should return OK");
        }

        [Fact]
        public void Button1_Command()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            vm.Button1Command.Execute(null);
            var ret = mbe.LastReturn;
            Assert.True(ret == MessageBoxServiceResult.OK, "This Path should return OK");
        }

        [Fact]
        public void Button2_Command()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            vm.Button2Command.Execute(null);
            var ret = mbe.LastReturn;
            Assert.True(ret == MessageBoxServiceResult.OK, "This Path should return OK");
        }

        [Fact]
        public void Button3_Command()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            vm.Button3Command.Execute(null);
            var ret = mbe.LastReturn;
            Assert.True(ret == MessageBoxServiceResult.OK, "This Path should return OK");
        }
                [Fact]
        public void Button4_Command()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            vm.Button4Command.Execute(null);
            var ret = mbe.LastReturn;
            Assert.True(ret == MessageBoxServiceResult.OK, "This Path should return OK");
        }
                [Fact]
        public void Button5_Command()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            vm.Button5Command.Execute(null);
            var ret = mbe.LastReturn;
            Assert.True(ret == MessageBoxServiceResult.OK, "This Path should return OK");
        }
        /// <summary>
        /// See Diagram MessageBoxPathToTest.jpg
        /// Shows path to reach Box #1
        /// </summary>
        [Fact]
        public void TestComplexPathWithMessageBoxes_1()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Yes);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Yes);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);

            MainWindowViewModel mwvm = new MainWindowViewModel(mbe);
            var ret = mwvm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 1, "This Path should return 1");
        }

        /// <summary>
        /// See Diagram MessageBoxPathToTest.jpg
        /// Shows path to reach Box #2
        /// </summary>
        [Fact]
        public void TestComplexPathWithMessageBoxes_2()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Yes);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Yes);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Cancel);

            MainWindowViewModel mwvm = new MainWindowViewModel(mbe);
            var ret = mwvm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 2, "This Path should return 2");
        }

        /// <summary>
        /// See Diagram MessageBoxPathToTest.jpg
        /// Shows path to reach Box #3
        /// </summary>
        [Fact]
        public void TestComplexPathWithMessageBoxes_3()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Yes);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            var ret = vm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 3, "This Path should return 3");
        }

        /// <summary>
        /// See Diagram MessageBoxPathToTest.jpg
        /// Shows path to reach Box #4
        /// </summary>
        [Fact]
        public void TestComplexPathWithMessageBoxes_4()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Cancel);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Yes);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            var ret = vm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 4, "This Path should return 4");
        }

        /// <summary>
        /// See Diagram MessageBoxPathToTest.jpg
        /// Shows path to reach Box #5
        /// </summary>
        [Fact]
        public void TestComplexPathWithMessageBoxes_5()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Cancel);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            var ret = vm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 5, "This Path should return 5");
        }

        /// <summary>
        /// See Diagram MessageBoxPathToTest.jpg
        /// Shows path to reach Box #6
        /// </summary>
        [Fact]
        public void TestComplexPathWithMessageBoxes_6()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Yes);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            var ret = vm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 6, "This Path should return 6");
        }

        /// <summary>
        /// See Diagram MessageBoxPathToTest.jpg
        /// Shows path to reach Box #7
        /// </summary>
        [Fact]
        public void TestComplexPathWithMessageBoxes_7()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            var ret = vm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 7, "This Path should return 7");
        }

        /// <summary>
        /// See Diagram MessageBoxPathToTest.jpg
        /// Shows path to reach Box #8
        /// </summary>
        [Fact]
        public void TestComplexPathWithMessageBoxes_8()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Cancel);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            var ret = vm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 8, "This Path should return 8");
        }

        /// <summary>
        /// See Diagram MessageBoxPathToTest.jpg
        /// Shows path to reach Box #9
        /// </summary>
        [Fact]
        public void TestComplexPathWithMessageBoxes_9()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Cancel);

            MainWindowViewModel vm = new MainWindowViewModel(mbe);
            var ret = vm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 9, "This Path should return 9");
        }

    }
    /// <summary>
    /// Simulates MessageBox Service so the code 
    /// referencing IMessageBoxService can be unit tested
    /// </summary>
    public class MessageBoxServiceSimulator : IMessageBoxService
    {
        /// List of answers a messagebox should return during the lifetime of the instance MessageBoxServiceSimulator
        Queue<MessageBoxServiceResult> messageBoxServiceResults = new Queue<MessageBoxServiceResult>();

        /// <summary>
        /// List of answers a messagebox should return during its lifeitme (TEST)
        /// The Queue will return one prefilled answer each time the Show() method is called (in queue order)
        /// The Queue should be filled with the proper number of answer for the unit test
        /// </summary>
        public Queue<MessageBoxServiceResult> ButtonQueue { get => messageBoxServiceResults; set => messageBoxServiceResults = value; }

        /// <summary>
        /// Keep the last button clicked (TEST)
        /// </summary>
        public MessageBoxServiceResult LastReturn { get; set; }

        public MessageBoxServiceSimulator()
        {

        }

        public MessageBoxServiceResult Show(string messageBoxText)
        {
            LastReturn = messageBoxServiceResults.Dequeue();
            return LastReturn;
        }

        public MessageBoxServiceResult Show(string messageBoxText, string caption)
        {
            LastReturn = messageBoxServiceResults.Dequeue();
            return LastReturn;
        }

        public MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button)
        {
            LastReturn = messageBoxServiceResults.Dequeue();
            return LastReturn;
        }

        public MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon)
        {
            LastReturn = messageBoxServiceResults.Dequeue();
            return LastReturn; }

        public MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon, MessageBoxServiceResult defaultResult)
        {
            LastReturn = messageBoxServiceResults.Dequeue();
            return LastReturn;
        }

        public MessageBoxServiceResult Show(Window owner, string messageBoxText)
        {
            LastReturn = messageBoxServiceResults.Dequeue();
            return LastReturn;
        }

        public MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption)
        {
            LastReturn = messageBoxServiceResults.Dequeue();
            return LastReturn;
        }

        public MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption, MessageBoxServiceButton button)
        {
            LastReturn = messageBoxServiceResults.Dequeue();
            return LastReturn;
        }

        public MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon)
        {
            LastReturn = messageBoxServiceResults.Dequeue();
            return LastReturn;
        }

        public MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon, MessageBoxServiceResult defaultResult)
        {
            LastReturn = messageBoxServiceResults.Dequeue();
            return LastReturn;
        }
    }
}

