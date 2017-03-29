// DescendingDestZipOrder.cs
// The purpose of this class is to implement an IComparer interface so that you can compare two parcels by destination zip

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescendingDestZipOrder : IComparer<Parcel>
    {
        // Precondition: none
        // Postcondition: The two parcels objects that are passed will be compared by destination zip
        public int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
                return 0;

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            int destZipCompare = p1.DestinationAddress.Zip - p2.DestinationAddress.Zip;

            if (destZipCompare > 0)
                return -1;
            else if (destZipCompare == 0)
                return 0;
            else
                return 1;
        }
    }
}
