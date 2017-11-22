using DevExpress.Mvvm;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Q550084
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
            Messenger.Default.Register<string>(this, message => MessageBox.Show(message));
        }
    }
    public class ViewModel
    {
        public ViewModel()
        {
            SendMessageCommand = new DelegateCommand<string>(SendMessage);
        }
        public ICommand SendMessageCommand
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }
        void SendMessage(string message)
        {
            Messenger.Default.Send<string>(message);
        }

    }

}
