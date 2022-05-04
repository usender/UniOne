using System;
using System.ComponentModel.DataAnnotations;

namespace Sender.UniOne.ApiClient.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = true)]
    public sealed class UrlValidationAttribute : ValidationAttribute
    {
        /// <summary>Determines whether the specified value of the object is valid.</summary>
        /// <param name="value">The value of the object to validate.</param>
        /// <returns>true if the specified value is valid; otherwise, false.</returns>
        public override bool IsValid(object value)
        {
            string url = Convert.ToString(value);
            if (string.IsNullOrEmpty(url))
                return true;

            return Uri.IsWellFormedUriString(url, UriKind.Absolute);
        }
    }
}
