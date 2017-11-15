<Query Kind="Program">
  <Namespace>System.Security.Cryptography</Namespace>
</Query>

//This code runs in Linqpad but can easly be ported over in .NET C#

void Main()
{
	RNGCryptoServiceProvider _ran = new RNGCryptoServiceProvider();
	string[] _seed = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "9" };
	string iotaseed = string.Empty;
	
	byte[] _data = new byte[8];	 //8 bytes to hold an unsigned bits int
	for (int i = 0; i <= 80; i++)	//The number times this will run in orde to fill the 81 char requirment
	{
		_ran.GetBytes(_data);
		var gennum = BitConverter.ToUInt64(_data, 0);
		var _num = (gennum % 27);
		iotaseed += _seed[_num];
	}

	iotaseed.Dump(); //Linqpad specific
	//Console.Write(iotaseed) //C#
}