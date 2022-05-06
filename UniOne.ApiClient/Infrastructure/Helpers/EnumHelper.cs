using System;
using System.Collections.Generic;

namespace Sender.UniOne.ApiClient.Infrastructure.Helpers
{
    internal static class EnumHelper
    {
        internal static IEnumerable<T> GetValues<T>() where T : Enum
        {
            var values = Enum.GetValues(typeof(T));

            foreach (var item in values)
            {
                yield return (T)item;
            }
        }
    }
}