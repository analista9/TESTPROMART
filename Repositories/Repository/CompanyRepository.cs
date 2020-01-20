using HilarioMarket.Data;
using HilarioMarket.DTO;
using HilarioMarket.Models;
using HilarioMarket.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HilarioMarket.Repositories.Repository
{
    public class CompanyRepository:ICompanyRepository
    {
        private readonly HilarioMarketServiceContext _context;
        public CompanyRepository(HilarioMarketServiceContext context)
        {
            _context = context;
        }
        public async Task Delete(int CompanyID)
        {
            Company company = await _context.HilarioMarket_Company.FindAsync(CompanyID);
            _context.HilarioMarket_Company.Remove(company);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<string> Insert(Company Company)
        {
            try
            {
                await _context.HilarioMarket_Company.AddAsync(Company);
                await Save();
                return "Ingreso Exitoso";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }

        public async Task<string> Update(Company Company)
        {
            try
            {
                _context.Entry(Company).State = EntityState.Modified;
                await Save();
                return "Actualizacion Exitosa";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
        public async Task<CompanyDTO> GetAll()
        {
            List<CompanyDTO.Company> companies = await (from c in _context.HilarioMarket_Company
                                                        select new CompanyDTO.Company
                                             {
                                                 IdCompany = c.IdCompany,
                                                 Description = c.Description,
                                                 products = (from p in _context.HilarioMarket_Product
                                                             where p.IdCompany == c.IdCompany
                                                            select new ProductDTO
                                                            {
                                                                IdProduct = p.IdProduct,
                                                                Description = p.Description,
                                                                BaseAmount = p.BaseAmount,
                                                                MarketAmount = p.MarketAmount,
                                                                Quantity = p.Quantity
                                                            }).ToList()                                                          
                                             }).ToListAsync();
            CompanyDTO companyResponse = new CompanyDTO
            {
                Data = companies
            };
            return companyResponse;
        }

        public async Task<CompanyDTO.Company> GetById(int CompanyID)
        {
            CompanyDTO.Company company = await (from c in _context.HilarioMarket_Company
                                                select new CompanyDTO.Company
                                                {
                                                    IdCompany = c.IdCompany,
                                                    Description = c.Description,
                                                    products = (from p in _context.HilarioMarket_Product
                                                                where p.IdCompany == c.IdCompany
                                                                select new ProductDTO
                                                                {
                                                                    IdProduct = p.IdProduct,
                                                                    Description = p.Description,
                                                                    BaseAmount = p.BaseAmount,
                                                                    MarketAmount = p.MarketAmount,
                                                                    Quantity = p.Quantity
                                                                }).ToList()
                                                }).FirstOrDefaultAsync();
            return company;
        }
    }
}
