using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Behaviors
{
    public class TransactionalBehavior<TRequest, TResponse> : 
        IPipelineBehavior<TRequest, TResponse> 
        where TRequest : ITransactional
        where TResponse : OperationResult, new()
    {
        private readonly ApplicationDbContext _dbContext;

        public TransactionalBehavior(ApplicationDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            TResponse response = default;

            try
            {
                Debug.WriteLine("Begin transaction");
                await _dbContext.Database.BeginTransactionAsync(cancellationToken);

                response = await next();

                Debug.WriteLine("Commit transaction");
                await _dbContext.Database.CommitTransactionAsync(cancellationToken);
            }
            catch
            {
                Debug.WriteLine("Rollback transaction");
                await _dbContext.Database.RollbackTransactionAsync(cancellationToken);

                throw;
            }

            return response;
        }
    }
}