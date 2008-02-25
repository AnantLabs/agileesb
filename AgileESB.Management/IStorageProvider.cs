using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AgileESB.Management
{
    /// <summary>
    /// Common interface for management data storage.
    /// </summary>
    internal interface IStorageProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="managementData"></param>
        void RetrieveData( string uri, DataSet managementData );

        /// <summary>
        /// 
        /// </summary>
        /// <param name="managementData"></param>
        void StoreData( string uri, DataSet managementData );
    }
}
