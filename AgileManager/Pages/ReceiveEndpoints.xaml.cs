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
using AgileESB.Management;

namespace AgileManager.Pages
{
    /// <summary>
    /// Interaction logic for Management.xaml
    /// </summary>
    public partial class ReceiveEndpoints : Page
    {
        public ReceiveEndpoints()
        {
            InitializeComponent();

            this.EndpointsList.ItemsSource =
                from item in App.MgmtData.ReceiveEndpoints select item;
        }

        private void EndpointsList_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            if( this.EndpointsList.SelectedIndex > -1 )
            {
                this.EndpointDetails.Visibility = Visibility.Visible;
                this.EndpointDetails.DataContext =
                    from item in App.MgmtData.ReceiveEndpoints
                    where item.Id == new Guid( this.EndpointsList.SelectedValue.ToString() )
                    select item;
            }
            else
            {
                this.EndpointDetails.Visibility = Visibility.Hidden;
            }
        }

        private void RevertButton_Click( object sender, RoutedEventArgs e )
        {

        }

        private void SaveButton_Click( object sender, RoutedEventArgs e )
        {
            App.MgmtData.SubmitChanges();
        }
    }
}
