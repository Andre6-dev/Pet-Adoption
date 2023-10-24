namespace Service.Contracts;

public interface IServiceManager
{
    IPetService PetService { get; }
    IVaccineService VaccineService { get; }
}