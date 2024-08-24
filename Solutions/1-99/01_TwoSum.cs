namespace Solutions._1_99
{
    internal class _1_TwoSum
    {
        public _1_TwoSum(int[] nums, int target)
        {
            int[] result = TwoSum(nums, target);

            Console.WriteLine(result.ToString<int>());
        }

        private int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length == 2) return [0, 1];

            int left = 0;
            int right = nums.Length - 1;
            int[] sortedNums = nums.OrderBy(x => x).ToArray();

            int leftValue = sortedNums[left];
            int rightValue = sortedNums[right];
            while (left < right)
            {
                if (leftValue + rightValue == target)
                {
                    return [Array.IndexOf(nums, sortedNums[left]), Array.LastIndexOf(nums, sortedNums[right])];
                }

                if (leftValue + rightValue > target)
                {
                    rightValue = sortedNums[--right];
                }
                else
                {
                    leftValue = sortedNums[++left];
                }
            }

            return [];
        }
    }
}
