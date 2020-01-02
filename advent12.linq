<Query Kind="Statements" />

//var data3 = new int[4, 3] { { -9, 10, -1 }, { -14, -8, 14 }, { 1, 5, 6 }, { -19, 7, 8 } };
var data = new int[4, 3] { { -9, 10, -1 }, { -14, -8, 14 }, { 1, 5, 6 }, { -19, 7, 8 } };
//var data = new int[4, 3] { { -1, 0, 2 }, { 2, -10, -7 }, { 4, -8, 8 }, { 3, 5, -1 } };
var data2 = new int[4, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

var dict = new Dictionary<string, int>();

using (System.IO.StreamWriter file = 
    new System.IO.StreamWriter(@"C:\Users\Public\WriteLines2.txt"))
{
for (var m = 0; m < 1000000; m++) // 1000 times
{
	for (var i = 0; i < data.GetLength(0); i++) // each moon
	{
		for (var j = 0; j < data.GetLength(0); j++) // compare to each other moon
		{
			for (var k = 0; k < 3; k++) // each position
			{
				if (i != j) // don't compare self
				{
					if (data[i, k] > data[j, k])
					{
						data2[i, k]--;
					}
					else if (data[i, k] < data[j, k])
					{
						data2[i, k]++;
					}
				}
			}
		}
	}
	
	
	
//	data[0, 0].Dump();
	

     file.WriteLine(data[0, 2]);

	
	
	
	
	
	for (var n = 0; n < data.GetLength(0); n++) // each moon
	{
		for (var p = 0; p < 3; p++) // each position
		{
			data[n, p] += data2[n, p];
		}
	}
	//		if (data3[1, 0] == data[1, 0] && data3[1, 1] == data[1, 1] && data3[1, 2] == data[1, 2])
	//		{
	//			Console.WriteLine($"{data3[1, 0]} == {data[1, 0]} && {data3[1, 1]} == {data[1, 1]} && {data3[1, 2]} == {data[1, 2]} ");
	//			Console.WriteLine(m); 
	//			Console.ReadLine();
	//		}

	var key = $"{data2[0, 0]},{ data2[0, 1]},{ data2[0, 2]}";
	if (!dict.ContainsKey(key))
	{
		dict.Add(key, m);
	}
	else
	{
//		m.Dump();
	}
	//	data.Dump("data");
	//	data2.Dump("data2");
}
    }
//data.Dump();
//data2.Dump();

//var energy = 0;
//
//for (var n = 0; n < data.GetLength(0); n++) // each moon
//{
//	var kin = 0;
//	var pos = 0;
//	for (var p = 0; p < 3; p++) // each position
//	{
//		pos += Math.Abs(data[n, p]);
//		kin += Math.Abs(data2[n, p]);
//	}
//	//	pos.Dump();
//	//	kin.Dump();
//	energy += pos * kin;
//}


//energy.Dump();
//data.Dump();
//data2.Dump();