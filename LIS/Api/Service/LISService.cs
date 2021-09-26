using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service
{
    public class LISService : ILISService
    {
        public async Task<string> FindLIS(string input)
        {
            //First let's convert the input string to an array of integers
            var inputArr = Array.ConvertAll(input.Trim().Split(' '), s => int.Parse(s));

            //The key of the dictionary is the starting index of the particular LIS sequence and will be used in orderby to output first appearing sequence if multiple sequences of same length are found
            var dictionaryLIS = new Dictionary<int, List<int>>();

            int currentSequenceLength; //This int variable will keep track of total elements in the current LIS sequence so that we can skip for loop iterations of those elements that already form part of LIS from a previous input
            int maxSequenceLength = 0; // This will keep track of max LIS sequence length so that we only add larger LIS sequence to the dictionary to keep the size of dictionary small.
            for (int i = 0; i < inputArr.Length; i += currentSequenceLength)
            {
                currentSequenceLength = 1;
                var currentSequence = new List<int> { inputArr[i] };

                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[j] > inputArr[j - 1])
                    {
                        currentSequence.Add(inputArr[j]);
                        currentSequenceLength++;
                    }
                    else
                    {
                        //The current int value is lesser than the previous one so break out of nested loop as it is not forming a LIS sequence anymore.
                        break;
                    }
                }

                if (currentSequenceLength > maxSequenceLength)
                {
                    //The current sequence length is greater than the previous max sequence length so we will update the max sequence length with current sequence length and also add the current sequence to the dictionary.
                    //We are only storing those sequences in the dictionary that are larger than the previous max sequence length as this will reduce the size of our dictionary once we complete the iterations.
                    //Skipping storing the lower length sequences in the dictionary will make our API resource efficient.
                    maxSequenceLength = currentSequenceLength;
                    dictionaryLIS.Add(i, currentSequence);
                }
            }

            //We have our dictionary with all the sequences stored in it.
            //Order the sequences in descending order by the length of the sequence and then by starting index of the sequence in the original input so that we can report first appearing longest length sequence. 
            var lis = string.Join(' ', dictionaryLIS.OrderByDescending(d => d.Value.Count).ThenBy(d => d.Key).FirstOrDefault().Value);
            return await Task.FromResult(lis);
        }
    }
}
