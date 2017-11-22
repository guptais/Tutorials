using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Docking;

namespace Q348396.Q348427 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }


        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            TextBlock panelCaption = new TextBlock();
            panelCaption.Inlines.Add(new Run("LayoutPanel :"));

            Run linkCriteria = new Run("1");
            linkCriteria.Foreground = Brushes.Red;
            panelCaption.Inlines.Add(linkCriteria);

            layout1.Caption = "1";// panelCaption;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            TextBlock panelCaption = new TextBlock();
            panelCaption.Inlines.Add(new Run("LayoutPanel :"));

            Run linkCriteria = new Run("2");
            linkCriteria.Foreground = Brushes.Red;
            panelCaption.Inlines.Add(linkCriteria);

            layout2.Caption = panelCaption;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            TextBlock panelCaption = new TextBlock();
            panelCaption.Inlines.Add(new Run("LayoutPanel :"));

            Run linkCriteria = new Run("3");
            linkCriteria.Foreground = Brushes.Red;
            panelCaption.Inlines.Add(linkCriteria);

            layout3.Caption = panelCaption;
        }
    }
}
