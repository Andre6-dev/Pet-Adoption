using Contracts;
using Entities.Models;

namespace Repository;

public class PetRepository : RepositoryBase<Pet>, IPetRepository
{
    public PetRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }
}