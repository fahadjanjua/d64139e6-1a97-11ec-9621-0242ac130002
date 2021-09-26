using System.Threading.Tasks;

namespace API.Service
{
    public interface ILISService
    {
        Task<string> FindLIS(string input);
    }
}
