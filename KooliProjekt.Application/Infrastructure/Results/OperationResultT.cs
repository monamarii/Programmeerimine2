namespace KooliProjekt.Application.Infrastructure.Results
{
    public class OperationResult<T> : OperationResult
    {
        public T Value { get; set; }

        public OperationResult() { }

        public OperationResult(T value) 
        { 
            Value = value;
        }        

        public new OperationResult<T> AddError(string error)
        {
            base.AddError(error);

            return this;
        }

        public new OperationResult<T> AddPropertyError(string propertyName, string error)
        {
            base.AddPropertyError(propertyName, error);

            return this;
        }
    }
}