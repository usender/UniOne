using System;
using System.ComponentModel.DataAnnotations;

namespace Sender.UniOne.ApiClient.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class AttachmentNameValidationAttribute : ValidationAttribute
    {
        internal AttachmentNameValidationAttribute()
            : base("The symbol \"/\" is not allowed in attachment name")
        {

        }

        public override bool IsValid(object value)
        {
            string name = Convert.ToString(value);
            if (string.IsNullOrEmpty(name))
                return false;

            return !name.Contains("/");
        }
    }
}
