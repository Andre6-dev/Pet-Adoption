using Contracts;
using Service.Contracts;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IPetService> _petService;
    private readonly Lazy<IVaccineService> _vaccineService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
    {
        _petService = new Lazy<IPetService>(() => new PetService(repositoryManager, logger));
        _vaccineService = new Lazy<IVaccineService>(() => new VaccineService(repositoryManager, logger));
    }
    
    public IPetService PetService => _petService.Value;
    public IVaccineService VaccineService => _vaccineService.Value;
}