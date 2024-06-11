using OpticsSetsMy.ViewModels;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Telerik.Windows.Controls;

namespace OpticsSetsMy
{
    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel;
        public MainWindow()
        {
            viewModel = new MainWindowViewModel();
            InitializeComponent();
            DataContext = viewModel;
        }

        private void RadButton_Click(object sender, RoutedEventArgs e)
        {
            SoczewkaLewaList.SelectedIndex = 33;
            SoczewkaLewaList.ScrollIntoView(SoczewkaLewaList.SelectedItem);
        }

        private void RadListBox_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            var scrollViewer = FindParent<ScrollViewer>((DependencyObject)sender);
            if (scrollViewer != null)
            {
                if (e.Delta > 0)
                    scrollViewer.LineUp();
                else
                    scrollViewer.LineDown();

                e.Handled = true;
            }
        }

        private static T FindParent<T>(DependencyObject child) where T : DependencyObject
        {
            DependencyObject parentObject = VisualTreeHelper.GetParent(child);

            if (parentObject == null) return null;

            T parent = parentObject as T;
            if (parent != null)
            {
                return parent;
            }
            else
            {
                return FindParent<T>(parentObject);
            }
        }

        private void OprawkaList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ScrollToSelectedItem(sender as RadListBox);
        }

        private void SoczewkaLewaList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ScrollToSelectedItem(sender as RadListBox);
        }

        private void KompletOpticsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ScrollToSelectedItem(sender as RadListBox);
        }

        private void SoczewkaPrawaList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ScrollToSelectedItem(sender as RadListBox);
        }

        private void ScrollToSelectedItem(RadListBox listBox)
        {
            if (listBox != null && listBox.SelectedItem != null)
            {
                listBox.UpdateLayout();  // Ensure layout is updated to make the scroll effect visible
                listBox.ScrollIntoView(listBox.SelectedItem);
            }
        }
    }
}
