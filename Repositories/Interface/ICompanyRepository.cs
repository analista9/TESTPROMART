using HilarioMarket.DTO;
using HilarioMarket.Models;
using System.Threading.Tasks;

namespace HilarioMarket.Repositories.Interface
{
    public interface ICompanyRepository
    {
        Task<CompanyDTO> GetAll();
        Task<CompanyDTO.Company> GetById(int CompanyID);
        //Operaciones Transaccionales
        Task<string> Insert(Company Company);
        Task<string> Update(Company Company);
        Task Delete(int CompanyID);
        Task Save();
    }
}
