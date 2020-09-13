internal class Program
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
            if (_nums.Length <= 0)
            {
                return 0;
            }

            int index = 0;
            for (int j = 1; j < _nums.Length; j++)
            {
                if (_nums[j] != _nums[index])
                {
                    _nums[++index] = _nums[j];
                    WriteArray(_nums);
                }
            }

            return index + 1;
        }

        /// <summary>
        /// Write Array
        /// </summary>
        /// <param name="_nums"></param>
        private static void WriteArray(int[] _nums)
        {
            foreach (var num in _nums)
            {
                Console.Write(num+"\t");
            }
            Console.WriteLine("");
        }
	}
}