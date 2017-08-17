using System.Threading.Tasks;

namespace MvvmLight.Model
{
    public interface IDataService
    {
        Task<DataItem> GetData();
    }
}