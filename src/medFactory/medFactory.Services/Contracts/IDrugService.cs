using medFactory.Domain.Models;

namespace medFactory.Services.Contracts;

public interface IDrugService
{
    public IEnumerable<Drug> GetDrugs();
}