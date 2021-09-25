using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.API.Service
{
    public interface ILISService
    {
        Task<string> FindLIS(string input);
    }
}
