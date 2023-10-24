namespace Contracts;

public interface IRepositoryManager
{
    IPetRepository Pet { get; }
    IVaccineRepository Vaccine { get; }
}