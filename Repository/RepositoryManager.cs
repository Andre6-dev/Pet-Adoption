using Contracts;

namespace Repository;

// This class will create instances of repository user classes for us and then
// register them inside the dependency injection container.
public sealed class RepositoryManager : IRepositoryManager
{
    /*Lazy class to ensure the lazy initialization of our repositories.
     This means that our repository instancesare only going to be created when 
     we access them for the first time, and not before that*/
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IPetRepository> _petRepository;
    private readonly Lazy<IVaccineRepository> _vaccineRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _petRepository = new Lazy<IPetRepository>(() => new PetRepository(_repositoryContext));
        _vaccineRepository = new Lazy<IVaccineRepository>(() => new VaccineRepository(_repositoryContext));
    }
    
    public IPetRepository Pet => _petRepository.Value;
    public IVaccineRepository Vaccine => _vaccineRepository.Value;
    
    public void Save() => _repositoryContext.SaveChanges();
}