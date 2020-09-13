using System;

namespace ConsoleApplication1
{
    internal class 删除数组中的重复元素
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};

            var count = RemoveDuplicates(nums);
            Console.WriteLine($"count = {count}");
        }

        /// <summary>
        /// 移除重复元素
        /// </summary>
        /// <param name="_nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] _nums)
        {
            if (_nums.Length <= 1)
            {
                return 0;
            }

            int index = 0;
            for (int j = 1; j < _nums.Length; j++)
            {
                if (_nums[j] != _nums[index])
                {
                    _nums[++index] = _nums[j];
                    // WriteArray(_nums);
                }
            }

            return index + 1;
            
            // 以下是每次执行 nums[index] != nums[j]时的数据状态，有助于理解
            // 0    1       1       1       1       2       2       3       3       4
            // 0    1       2       1       1       2       2       3       3       4
            // 0    1       2       3       1       2       2       3       3       4
            // 0    1       2       3       4       2       2       3       3       4

        }

        /// <summary>
        /// Write Array
        /// </summary>
        /// <param name="_nums"></param>
        private static void WriteArray(int[] _nums)
        {
            Console.Write("// ");
            foreach (var num in _nums)
            {
                Console.Write(num + "\t");
            }

            Console.WriteLine("");
        }
    }
}