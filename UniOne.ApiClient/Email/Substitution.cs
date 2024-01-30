using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;

namespace Sender.UniOne.ApiClient.Email
{
    public class Substitution : DynamicObject, IDictionarySource
    {
        private const string TO_NAME = "to_name";
        private const int TO_NAME_MAX_LENGTH = 78;

        private readonly Dictionary<string, string> _properties;

        /// <summary>
        /// Property use in message body. Use as {{to_name}}
        /// There’s a special substitution “to_name” which is used to put recipient’s name like “Name Surname” to include it to SMTP header “To” in the form “Name Surname <email@example.com>”
        /// </summary>
        [JsonProperty(TO_NAME, NullValueHandling = NullValueHandling.Ignore)]
        [MaxLength(TO_NAME_MAX_LENGTH)]
        public string ToName { get; set; }

        public Dictionary<string, string> GetProperties()
        {
            var properties = _properties.ToDictionary(x => x.Key, y => y.Value);

            if (ToName != null)
            {
                properties.Add(TO_NAME, ToName);
            }

            return properties;
        }

        public Substitution()
        {
            _properties = new Dictionary<string, string>();
        }

        public void Add(string propName, string propValue)
        {
            if (string.IsNullOrWhiteSpace(propName))
            {
                return;
            }

            if (propName.ToLower() == TO_NAME)
            {
                ToName = propValue;
                return;
            }

            if (!_properties.ContainsKey(propName))
            {
                _properties.Add(propName, propValue);
            }
        }

        public void AddRange(Dictionary<string, string> properties)
        {
            foreach (var property in properties)
            {
                Add(property.Key, property.Value);
            }
        }

        public override IEnumerable<string> GetDynamicMemberNames() => _properties.Keys;

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (_properties.ContainsKey(binder.Name))
            {
                result = _properties[binder.Name];
                return true;
            }

            result = null;
            return false;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (_properties.ContainsKey(binder.Name))
            {
                _properties[binder.Name] = value == null ? null : Convert.ToString(value);
                return true;
            }

            return false;
        }
    }
}