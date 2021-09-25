using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIS.API.Service
{
    public class LISService : ILISService
    {
        public async Task<string> FindLIS(string input)
        {
            var inputArr = Array.ConvertAll(input.Split(' '), s => int.Parse(s));
            var dic = new Dictionary<int, List<int>>();

            var currentSequenceLength = 1;
            for (int i = 0; i < inputArr.Length; i += currentSequenceLength)
            {
                currentSequenceLength = 1;
                var currentSequence = new List<int> { inputArr[i] };
                if (i == inputArr.Length - 1)
                {
                    dic.Add(i, currentSequence);
                    break;
                }
                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[j] > inputArr[j - 1])
                    {
                        currentSequence.Add(inputArr[j]);
                        currentSequenceLength++;
                    }
                    else
                    {
                        break;
                    }
                }
                dic.Add(i, currentSequence);
            }

            var lis = string.Join(' ', dic.OrderByDescending(d => d.Value.Count).ThenBy(d => d.Key).FirstOrDefault().Value);
            return await Task.FromResult(lis);
        }
    }
}
