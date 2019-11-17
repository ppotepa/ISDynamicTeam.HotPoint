using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISDynamicTeam.HotPoint.Server
{
    public class GUIDHelper
    {
        //public static IEnumerable<Guid> GetRandomNumberOfGuids()
        //{
        //    short range = (short)new Random().Next(Int16.MaxValue);
        //    return Enumerable.Range(0, range).Select(el => Guid.NewGuid());
        //}

        public static IEnumerable<Guid> GetNumberOfGuid(int count)
        {
            List<Guid> result = new List<Guid>();
            for (var i = 0; i < count; i++) result.Add(Guid.NewGuid());
            return result;
        }

        internal static IEnumerable<Guid> GetRandomNumberOfGuids()
        {
            throw new NotImplementedException();
        }
    }
}
