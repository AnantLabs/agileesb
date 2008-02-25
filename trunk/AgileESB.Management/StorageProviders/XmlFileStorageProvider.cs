using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Data;

namespace AgileESB.Management.StorageProviders
{
    public class XmlFileStorageProvider : IStorageProvider
    {
        #region IStorageProvider Members
        public void RetrieveData( string uri, DataSet managementData )
        {
            XDocument source = XDocument.Load( uri );
        }

        public void StoreData( string uri, DataSet managementData )
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
