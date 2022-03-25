using Dialog.ViewModels;
using MessageBoxUtilities;
using System.Collections.Generic;
using System.Windows;
using Xunit;

namespace MessageBoxUnitTests
{
    public class MainWindowViewModelTest
    {
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
            Assert.True( ret == 1,"This Path should return 1");
        }

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

        [Fact]
        public void TestComplexPathWithMessageBoxes_3()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Yes);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);

            MainWindowViewModel mwvm = new MainWindowViewModel(mbe);
            var ret = mwvm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 3, "This Path should return 3");
        }

        [Fact]
        public void TestComplexPathWithMessageBoxes_4()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Cancel);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Yes);

            MainWindowViewModel mwvm = new MainWindowViewModel(mbe);
            var ret = mwvm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 4, "This Path should return 4");
        }

        [Fact]
        public void TestComplexPathWithMessageBoxes_5()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Cancel);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);

            MainWindowViewModel mwvm = new MainWindowViewModel(mbe);
            var ret = mwvm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 5, "This Path should return 5");
        }

        [Fact]
        public void TestComplexPathWithMessageBoxes_6()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Yes);

            MainWindowViewModel mwvm = new MainWindowViewModel(mbe);
            var ret = mwvm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 6, "This Path should return 6");
        }

        [Fact]
        public void TestComplexPathWithMessageBoxes_7()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);

            MainWindowViewModel mwvm = new MainWindowViewModel(mbe);
            var ret = mwvm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 7, "This Path should return 7");
        }

        [Fact]
        public void TestComplexPathWithMessageBoxes_8()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.OK);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Cancel);

            MainWindowViewModel mwvm = new MainWindowViewModel(mbe);
            var ret = mwvm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 8, "This Path should return 8");
        }

        [Fact]
        public void TestComplexPathWithMessageBoxes_9()
        {
            MessageBoxServiceSimulator mbe = new MessageBoxServiceSimulator();
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.No);
            mbe.ButtonQueue.Enqueue(MessageBoxServiceResult.Cancel);

            MainWindowViewModel mwvm = new MainWindowViewModel(mbe);
            var ret = mwvm.ComplexPathWithMessageBoxes();
            Assert.True(ret == 9, "This Path should return 9");
        }

    }
    public class MessageBoxServiceSimulator : IMessageBoxService
    {
        Queue<MessageBoxServiceResult> messageBoxServiceResults = new Queue<MessageBoxServiceResult>();

        public Queue<MessageBoxServiceResult> ButtonQueue  { get => messageBoxServiceResults; set => messageBoxServiceResults = value; }

        public MessageBoxServiceSimulator()
        {

        }

        public MessageBoxServiceResult Show(string messageBoxText)
        {
            return messageBoxServiceResults.Dequeue();
        }

        public MessageBoxServiceResult Show(string messageBoxText, string caption)
        {
            return messageBoxServiceResults.Dequeue();
        }

        public MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button)
        {
            return messageBoxServiceResults.Dequeue();
        }

        public MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon)
        {
            return messageBoxServiceResults.Dequeue();
        }

        public MessageBoxServiceResult Show(string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon, MessageBoxServiceResult defaultResult)
        {
            return messageBoxServiceResults.Dequeue();
        }

        public MessageBoxServiceResult Show(Window owner, string messageBoxText)
        {
            return messageBoxServiceResults.Dequeue();
        }

        public MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption)
        {
            return messageBoxServiceResults.Dequeue();
        }

        public MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption, MessageBoxServiceButton button)
        {
            return messageBoxServiceResults.Dequeue();
        }

        public MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon)
        {
            return messageBoxServiceResults.Dequeue();
        }

        public MessageBoxServiceResult Show(Window owner, string messageBoxText, string caption, MessageBoxServiceButton button, MessageBoxServiceIcon icon, MessageBoxServiceResult defaultResult)
        {
            return messageBoxServiceResults.Dequeue();
        }
    }
}