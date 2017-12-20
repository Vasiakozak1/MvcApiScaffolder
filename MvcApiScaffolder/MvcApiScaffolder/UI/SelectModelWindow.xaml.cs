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

namespace MvcApiScaffolder.UI
{
    /// <summary>
    /// Interaction logic for SelectModelWindow.xaml
    /// </summary>
    public partial class SelectModelWindow : Window
    {
        public SelectModelWindow(CustomViewModel viewModel)
        {
            InitializeComponent();
            this.AddBtn.IsEnabled = false;
            DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.AddBtn.IsEnabled = IsValidComboBoxex(this.EntityType, this.DbContextType);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            this.AddBtn.IsEnabled = IsValidComboBoxex(this.EntityType, this.DbContextType);
        }

        private bool IsValidComboBoxex(ComboBox comboBox1, ComboBox comboBox2)
        {
            var firstType = comboBox1.SelectedValue as ModelType;
            var secondType = comboBox2.SelectedValue as ModelType;
            return firstType != null && secondType != null;
        }

        private void DbContextType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.AddBtn.IsEnabled = IsValidComboBoxex(this.EntityType, this.DbContextType);
        }
    }
}
