using medFactory.Domain.Models;
using medFactory.EF.Contracts;

namespace medFactory.EF.Repository;

public class DrugRepository : GenericRepository<Drug>, IDrugRepository
{
    public DrugRepository(DesignTimeDbContext context) : base(context)
    {
    }
}