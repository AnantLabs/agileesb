using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using AgileESB.Management;

namespace AgileManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static readonly ManagementObjectsDataContext MgmtData =
            new ManagementObjectsDataContext();
    }
}
