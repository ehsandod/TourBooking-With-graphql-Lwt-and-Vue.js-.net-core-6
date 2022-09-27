using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourBooking.Application.Commen
{
    public class CustomizeDataFilter
    {
        public static List<T> RemoveDuplicates<T>(List<T> items)
        {
            return (from s in items select s).Distinct().ToList();
        }
    }
}
