using System;
					
public class Program
{
	public static int[] FibArray(int num)
	{
		int n = num + 1;
		var a = new int[n];
		
		a[0] = 0;
		
		if (num == 0)
			return a;
		
		a[1] = 1;
		
		for (var i = 2; i < n; i++)
			a[i] = a[i-2] + a[i-1];
		return a;
	}
	
	public static void Main()
	{
		var foo = FibArray(12);
		foreach(var item in foo)
		{
			Console.WriteLine(item);
		}
	}
}