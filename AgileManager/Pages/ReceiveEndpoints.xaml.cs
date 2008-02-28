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
            this.EditName.Text = (string)this.EditName.Tag;
            this.EditUri.Text = (string)this.EditUri.Tag;
            this.CheckEnabled.IsChecked = (bool)this.CheckEnabled.Tag;

            this.ChangeNotification.Visibility = Visibility.Collapsed;
        }

        private void SaveButton_Click( object sender, RoutedEventArgs e )
        {
            App.MgmtData.SubmitChanges();

            this.ChangeNotification.Visibility = Visibility.Collapsed;
        }

        private void EditName_TextChanged( object sender, TextChangedEventArgs e )
        {
            this.ChangeNotification.Visibility =
                ItemChanged() ? Visibility.Visible : Visibility.Collapsed;
        }

        private void EditUri_TextChanged( object sender, TextChangedEventArgs e )
        {
            this.ChangeNotification.Visibility =
                ItemChanged() ? Visibility.Visible : Visibility.Collapsed;
        }

        private void CheckEnabled_Checked( object sender, RoutedEventArgs e )
        {
            this.ChangeNotification.Visibility = 
                ItemChanged() ? Visibility.Visible : Visibility.Collapsed;
        }

        private bool ItemChanged()
        {
            if( (null != this.EditName.Tag) && (0 != String.Compare( this.EditName.Text, (string)this.EditName.Tag )) )
            {
                return true;
            }
            if( (null != this.EditUri.Tag) && (0 != String.Compare( this.EditUri.Text, (string)this.EditUri.Tag )) )
            {
                return true;
            }
            Console.WriteLine( String.Format( "Tag: {0}", this.CheckEnabled.Tag ) );
            if( (null != this.CheckEnabled.Tag) && (this.CheckEnabled.IsChecked == (bool)this.CheckEnabled.Tag) )
            {
                return true;
            }
            return false;
        }
    }
}
