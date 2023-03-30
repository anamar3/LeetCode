using System;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int target = int.Parse(Console.ReadLine());
            TwoSum(input,target);
            int [] TwoSum(int[] nums, int target)
            {
                int[] newN = new int[2];
                for (int i = 0; i < nums.Length; i++)
                {
                    int currNum = nums[i];
                    for (int j = i+1; j < nums.Length; j++)
                    {
                        if (currNum + nums[j] == target)
                        {
                            string [] output = {$"{i}",$"{j}"};
                            int[] numbers = { i,j };
                            return numbers;
                        }
                    }
                }
                return newN;
            }
            
        }
    }
}
