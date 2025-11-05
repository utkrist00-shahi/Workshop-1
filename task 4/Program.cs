int[] nums = { 1, 3, 4, 5, 9 };
Array.Sort(nums);

foreach (int num in nums)
{
    Console.WriteLine(num);
}

Array.Reverse(nums);
foreach (int num in nums)
{
    Console.WriteLine(num);
}

int index = Array.IndexOf(nums, 5);
Console.WriteLine($"\nIndex of 5: {index}");