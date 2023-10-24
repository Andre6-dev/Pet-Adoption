using Contracts;
using Entities.Models;

namespace Repository;

public class VaccineRepository : RepositoryBase<Vaccine>, IVaccineRepository
{
    public VaccineRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }
}