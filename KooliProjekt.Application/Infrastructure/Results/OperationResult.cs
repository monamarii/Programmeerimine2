using System.Collections.Generic;

namespace KooliProjekt.Application.Infrastructure.Results
{
    public class OperationResult
    {
        public IDictionary<string, string> PropertyErrors { get; private set; }
        public IList<string> Errors { get; private set; }

        public bool HasErrors 
        {
            get
            {
                return PropertyErrors?.Count > 0 ||
                       Errors?.Count > 0;
            }
        }

        public bool ShouldSerializeHasErrors()
        {
            return HasErrors;
        }

        public OperationResult AddError(string error)
        {
            if (Errors == null)
            {
                Errors = new List<string>();
            }

            Errors.Add(error);

            return this;
        }

        public OperationResult AddPropertyError(string property, string error)
        {
            if (PropertyErrors == null)
            {
                PropertyErrors = new Dictionary<string, string>();
            }
            else if (PropertyErrors.ContainsKey(property))
            {
                return this;
            }

            PropertyErrors.Add(property, error);

            return this;
        }
    }
}