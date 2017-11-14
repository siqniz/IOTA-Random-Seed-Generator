<Query Kind="Program">
  <Namespace>System.Security.Cryptography</Namespace>
</Query>

//This code runs in Linqpad but can easly be ported over in .NET C#

void Main()
{
	string[] _seed = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "9" };
	List<int> _num = new List<int>();
	string iota = string.Empty;

	byte[] _data = new byte[27];
	for (int i = 0; i <= 80; i++)
	{
		RNGCryptoServiceProvider _ran = new RNGCryptoServiceProvider();
		_ran.GetBytes(_data);
		var gennum = BitConverter.ToInt32(_data, 0);
		var num = (Math.Abs(gennum % 27));
		iota += _seed[num];
	}

	iota.Dump();
}