using System;
using System.ComponentModel.DataAnnotations;

namespace Sender.UniOne.ApiClient.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class UrlValidationAttribute : ValidationAttribute
    {
        internal UrlValidationAttribute()
            : base("Url is not valid")
        {

        }

        public override bool IsValid(object value)
        {
            string url = Convert.ToString(value);
            if (string.IsNullOrEmpty(url))
                return true;

            return Uri.IsWellFormedUriString(url, UriKind.Absolute);
        }
    }
}
