<Query Kind="Program" />

//This code runs in Linqpad but can easly be ported over in .NET C#

void Main()
{
	string[] _seed = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "9"};
	List<int> _num = new List<int>();
	string iota = string.Empty;
	
	for (int i = 0; i <= 80; i++)
	{
		Random _random = new Random((int)DateTime.Now.Ticks + i + System.Environment.TickCount);
		var num = _random.Next(0, 27);
		iota+=_seed[num];
	}

	iota.Dump();
}

