<Query Kind="Program">
  <Namespace>System.Security.Cryptography</Namespace>
</Query>

//This code runs in Linqpad but can easly be ported over in .NET C#

void Main()
{
	string[] _seed = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "9" };
	string iotaseed = string.Empty;

	byte[] _data = new byte[27];	//27 becasue that is the number of availble chars including '9'
	for (int i = 0; i <= 80; i++)	//The number times this will run in orde to fill the 81 char requirment
	{
		RNGCryptoServiceProvider _ran = new RNGCryptoServiceProvider();
		_ran.GetBytes(_data);
		var gennum = BitConverter.ToInt32(_data, 0);
		var _num = (Math.Abs(gennum % 27));
		iotaseed += _seed[_num];
	}

	iotaseed.Dump(); //Linqpad specific
	//Console.Write(iotaseed) //C#
}