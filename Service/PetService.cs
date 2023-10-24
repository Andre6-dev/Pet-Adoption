using Contracts;
using Service.Contracts;

namespace Service;

internal sealed class PetService : IPetService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    
    public PetService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
}