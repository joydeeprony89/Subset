using System;
using System.Collections.Generic;

namespace Subset
{
  class Program
  {
    static void Main(string[] args)
    {
      Solution sol = new Solution();
      var nums = new int[] { 1, 2, 3 };
      var result = sol.Subsets(nums);
      foreach(var res in result)
      {
        Console.WriteLine(string.Join(",", res));
      }
    }
  }

  public class Solution
  {
    public IList<IList<int>> Subsets(int[] nums)
    {
      IList<IList<int>> result = new List<IList<int>>();
      result.Add(new List<int>());
      foreach (int no in nums)
      {
        int length = result.Count;
        for (int i = 0; i < length; i++)
        {
          List<int> innerResult = new List<int>();
          innerResult.AddRange(result[i]);
          innerResult.Add(no);
          result.Add(innerResult);
        }
      }

      return result;
    }
  }
}
