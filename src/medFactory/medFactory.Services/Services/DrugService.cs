using medFactory.Domain.Models;
using medFactory.EF.Contracts;
using medFactory.Services.Contracts;

namespace medFactory.Services.Services;

public class DrugService : IDrugService
{
    private readonly IUnitOfWork _unitOfWork;

    public DrugService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<Drug> GetDrugs()
    {
        var drugs = _unitOfWork.Drugs.GetAll();
        return drugs;
    }
    
}