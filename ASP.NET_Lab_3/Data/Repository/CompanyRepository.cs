using ASP.NET_Lab_3.Data.Interfaces;
using ASP.NET_Lab_3.Data.Models;

namespace ASP.NET_Lab_3.Data.Repository
{
    public class CompanyRepository : IClothesCompany
    {
        private readonly AppDBContent appDBContent;
        public CompanyRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Company> AllCompanies => appDBContent.Company;
    }
}
