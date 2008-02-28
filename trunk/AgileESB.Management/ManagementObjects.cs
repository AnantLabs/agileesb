using System.Data.Linq;

namespace AgileESB.Management
{
    partial class ManagementObjectsDataContext
    {
        /// <summary>
        /// Checks whether this DataContext has changes.
        /// </summary>
        /// <returns>True if this DataContext has any changes, false otherwise</returns>
        public bool HasChanges()
        {
            // Get the current state of changes
            ChangeSet changeSet = this.GetChangeSet();

            // Check all three collections
            return
                (changeSet.Deletes.Count > 0) ||
                (changeSet.Updates.Count > 0) ||
                (changeSet.Inserts.Count > 0);
        }
    }
}
