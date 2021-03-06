using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

using SIARH.Persistence.UnitOfWork;

using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Services
{
    public class PipelineSaveChanges<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {       
        private readonly ILogger<PipelineSaveChanges<TRequest, TResponse>> _logger;
        private readonly IUnitOfWork unitOfWork;
        private readonly IHttpContextAccessor httpContextAccessor;

        public PipelineSaveChanges(ILogger<PipelineSaveChanges<TRequest, TResponse>> logger, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            this.unitOfWork = unitOfWork;
            this.httpContextAccessor = httpContextAccessor;
        }
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            string requestName = typeof(TRequest).Name;
            string unqiueId = Guid.NewGuid().ToString();
            _logger.LogInformation($"ENTRANDOOOOO Request Id:{unqiueId}, request name:{requestName}");
            
            _logger.LogInformation("*********");
            _logger.LogInformation(httpContextAccessor.HttpContext.Request.Method.ToString());            
            _logger.LogInformation("*********");

            var timer = new Stopwatch();
            timer.Start();
            var response = await next();
            timer.Stop();
            await unitOfWork.CompleteAsync();
            _logger.LogInformation($"SALIENDOOO Request Id:{unqiueId}, request name:{requestName}, total request time:{timer.ElapsedMilliseconds}");
            return response;
        }
        
    }
}
