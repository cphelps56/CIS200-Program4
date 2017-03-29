// ExtraCreditOrder.cs
// The purpose of this class is to implement an IComparer interface that will allow to parcels to be compared by type and cost

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ExtraCreditOrder : IComparer<Parcel>
    {
        // Precondition: none
        // Postcondition: The two parcels objects passed will be compared by parcel type and cost
        public int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
                return 0;

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            int typeCompare = string.Compare(p1.GetType().ToString(), p2.GetType().ToString());

            decimal costCompare = p2.CalcCost() - p1.CalcCost();

            if (typeCompare != 0)
                return typeCompare;
            else
            {
                if (costCompare > 0)
                    return 1;
                else if (costCompare == 0)
                    return 0;
                else
                    return -1;
            }
        }
    }
}
