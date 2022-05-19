using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

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

        internal static string GetEnumMemberValue<T>(T value) where T : Enum
        {
            var member = typeof(T).GetTypeInfo().DeclaredMembers.Single(x => x.Name == value.ToString());
            var attr = member.GetCustomAttribute<EnumMemberAttribute>();
            return attr?.Value;
        }
    }
}