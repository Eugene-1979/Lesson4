// See https://aka.ms/new-console-template for more information
char ch;
do
{

try
	{

	Console.WriteLine("\nInput X");
	string strx = Console.ReadLine();
int x = Convert.ToInt32(strx);
	Console.WriteLine("Input Y");
	string stry = Console.ReadLine();

	
		
		int y = Convert.ToInt32(stry);
		Console.WriteLine(sum(x, y));
	}
	catch (FormatException)
	{

		Console.WriteLine("Invalid input");
		break;
	}
	Console.WriteLine("\r\nwant more   yes- input y or Y");
	ch = Console.ReadKey().KeyChar;

} while (ch == 'y' || ch == 'Y');




static int sum (int start,int end)
{
	if (start > end) return sum(end, start);
	int val = 0;
	for (int i = start; i <= end; i++)
	{
		val += i;
	}
	return val;
}