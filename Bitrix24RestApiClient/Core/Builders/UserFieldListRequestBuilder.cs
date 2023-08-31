using System.Collections.Generic;
using BXRest.Core.Builders;

namespace BXRest.Core.Builders
{
    public class UserFieldListRequestBuilder
    {
        private Dictionary<string, string> fieldsToAddOrUpdate = new Dictionary<string, string>();

        public UserFieldListRequestBuilder SetField(string fieldName, string value)
        {
            fieldsToAddOrUpdate[fieldName] = value;
            return this;
        }

        public Dictionary<string, string> Get()
        {
            return fieldsToAddOrUpdate;
        }
    }
}
