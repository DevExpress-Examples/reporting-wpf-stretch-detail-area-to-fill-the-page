using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Printing;

namespace PageHeightDemo {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            SimpleLink link = new SimpleLink((DataTemplate)Resources["detail"], 1);
            link.PageHeader = (DataTemplate)Resources["pageHeader"];
            link.PageFooter = (DataTemplate)Resources["pageFooter"];
            link.ShowPrintPreviewDialog(this);
        }
    }
}
