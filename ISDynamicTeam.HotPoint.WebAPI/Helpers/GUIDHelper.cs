using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISDynamicTeam.HotPoint.WebAPI.Helpers
{
    public class GUIDHelper
    {
        public static IEnumerable<Guid> GetRandomNumberOfGuids() {
            short range = (short) new Random().Next(Int16.MaxValue);
            return Enumerable.Range(0, range).Select(el => Guid.NewGuid());
        }
    }
}
