using System;

namespace ConsoleApplication1
{
    public class 旋转数组
    {
        /// <summary>
        /// 旋转数组
        /// 给定一个数组和偏移值k，求出移动后的数组
        /// </summary>
        /// <param name="_nums"></param>
        /// <returns></returns>
        public static int[] RotateArray(int[] _nums, int _k)
        {
            int temp, previous;
            for (int step = 0; step < _k; step++)
            {
                previous = _nums[_nums.Length - 1];
                for (int j = 0; j < _nums.Length; j++)
                {
                    temp = _nums[j];
                    _nums[j] = previous;
                    previous = temp;
                }
            }
            return _nums;
        }
    }
}