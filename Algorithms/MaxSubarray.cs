void Main()
{

	int result = maxSubArray(new int[] {-2,1,-3,4,-1,2,1,-5,4});
	result.Dump();
	
}

public int maxSubArray(int[] nums)
{
	//This is a DP solution
	int currentRunningSum = nums[0];
	int prevRunnigSum = nums[0];
	int max= nums[0];
	
	for (int x=1 ; x< nums.Length; x++)
	{
		//each iteration we decide to restart the sum from this cell or take the prev running sum?
		int takePrevious = prevRunnigSum + nums[x];
		currentRunningSum = takePrevious>nums[x]? takePrevious:nums[x];
		max= currentRunningSum>max? currentRunningSum:max;
		prevRunnigSum=currentRunningSum;
	}
	
	return max;
}
