/*
* CompanySize
* A company has a hierarchical structure where a manager can manage at most 8 employees.  All employees have exactly 1 manager
* except for the top level manager whom does not have a manager.
*
* Write a function to calculate the maximum number of employees possible at the company for a given number of management levels n.
* Solve recursively or iteratively using no built in math power libraries.
*
*   solve(int n);
*
*     Ex 1 solve(0) = 1
*     Ex 2 solve(1) = 9
*     Ex 3 solve(2) = 73
*/

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("For management level 0: " + solve(0));
		Console.WriteLine("For management level 1: " + solve(1));
		Console.WriteLine("For management level 2: " + solve(2));
		
		Console.WriteLine();
		Console.Write("Enter a management level: ");
		int managementLevel = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("For management level " + managementLevel + ": " + solve(managementLevel));
		Console.ReadLine();
	}

	private static int solve(int managementLevel)
	{
		if (managementLevel == 0)
		{
			return 1;
		}

		else
		{
			return 8 * solve(managementLevel - 1) +  1;
		}
	}
}