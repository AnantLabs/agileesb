using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.IO;

namespace AgileESB.Management
{
    public class Management
    {
        #region Properties
        /// <summary>
        /// Management data container
        /// </summary>
        private Dictionary<Guid,ReceiveEndpoint> _managementData = 
            new Dictionary<Guid,ReceiveEndpoint>();
        #endregion

        #region Public methods
        public void Initialize()
        {
        }
        #endregion
    }
}
