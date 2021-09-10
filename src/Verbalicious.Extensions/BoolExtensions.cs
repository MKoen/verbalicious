using System.Collections.Generic;
using System.Linq;

namespace Verbalicious.Extensions
{
    public static class BoolExtensions
    {
        public static bool IsTrue(this bool boolean) => boolean == true;

        public static bool IsFalse(this bool boolean) => boolean == false;

        public static bool IsAtLeastOneTrue(this IEnumerable<bool> booleans) => booleans.Any(b => b.IsTrue());

        public static bool IsAtLeastOneFalse(this IEnumerable<bool> booleans) => booleans.Any(b => b.IsFalse());

        public static bool AreAllTrue(this IEnumerable<bool> booleans) => booleans.All(b => b.IsTrue());

        public static bool AreAllFalse(this IEnumerable<bool> booleans) => booleans.All(b => b.IsFalse());
    }
}
