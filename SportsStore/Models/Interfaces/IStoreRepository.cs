using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Threading.Tasks;
namespace SportsStore.Models.Interfaces
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
