using Contracts;
using Service.Contracts;

namespace Service;

internal sealed class VaccineService : IVaccineService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    
    public VaccineService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
    
}