using ASP.NET_Lab_3.Data.Interfaces;
using ASP.NET_Lab_3.Data.Models;

namespace ASP.NET_Lab_3.Data.Repository
{
    public class TypesRepository : IClothesTypes
    {
        private readonly AppDBContent appDBContent;
        public TypesRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Types> AllTypes => appDBContent.Types;
    }
}
