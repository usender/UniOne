using System;
using System.Collections.Generic;

namespace Sender.UniOne.ApiClient.Infrastructure.Helpers
{
    internal static class EnumHelper
    {
        internal static IEnumerable<T> GetValues<T>() where T : Enum
        {
            if (!typeof(T).IsEnum)
            {
                throw new Exception("T must be enum.");
            }

            var values = Enum.GetValues(typeof(T));

            foreach (var item in values)
            {
                yield return (T)item;
            }
        }
    }
}