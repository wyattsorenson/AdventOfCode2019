<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var listQs = new List<Queue<int>>();
listQs.Add(new Queue<int>());
listQs[0].Enqueue(5);
listQs.Add(new Queue<int>());
listQs[1].Enqueue(6);
listQs.Add(new Queue<int>());
listQs[2].Enqueue(7);
listQs.Add(new Queue<int>());
listQs[3].Enqueue(8);
listQs.Add(new Queue<int>());
listQs[4].Enqueue(9);


void doIt(int p)
{
	int mode1 = 0;
	int phase = p;
	var after = p == 9 ? 5 : phase + 1;
	int mode2 = 0;
	var parameters = new char[3];
	var intcode = new List<int>() { 3, 8, 1001, 8, 10, 8, 105, 1, 0, 0, 21, 34, 51, 64, 73, 98, 179, 260, 341, 422, 99999, 3, 9, 102, 4, 9, 9, 1001, 9, 4, 9, 4, 9, 99, 3, 9, 1001, 9, 4, 9, 1002, 9, 3, 9, 1001, 9, 5, 9, 4, 9, 99, 3, 9, 101, 5, 9, 9, 102, 5, 9, 9, 4, 9, 99, 3, 9, 101, 5, 9, 9, 4, 9, 99, 3, 9, 1002, 9, 5, 9, 1001, 9, 3, 9, 102, 2, 9, 9, 101, 5, 9, 9, 1002, 9, 2, 9, 4, 9, 99, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 99, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 99, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 99, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 99, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 99 };
//	var intcode = new List<int>() { 3, 26, 1001, 26, -4, 26, 3, 27, 1002, 27, 2, 27, 1, 27, 26, 27, 4, 27, 1001, 28, -1, 28, 1005, 28, 6, 99, 0, 0, 5};

	for (int i = 0; intcode[i] != 99; i += 4)
	{
		var str = intcode[i].ToString();
		char opcode = str[str.Length - 1];
		if (str.Length > 2)
		{
			str = str.Substring(0, str.Length - 2);
			char[] charArray = str.ToCharArray();
			Array.Reverse(charArray);
			str = new string(charArray);

			try { parameters[0] = str[0]; } catch { parameters[0] = '0'; }
			try { parameters[1] = str[1]; } catch { parameters[1] = '0'; }
			try { parameters[2] = str[2]; } catch { parameters[2] = '0'; }
		}
		else
		{
			parameters[0] = '0';
			parameters[1] = '0';
			parameters[2] = '0';
		}

		switch (opcode)
		{
			case '1':
				try
				{
					if (parameters[0] == '0') { mode1 = intcode[intcode[i + 1]]; }
					if (parameters[1] == '0') { mode2 = intcode[intcode[i + 2]]; }
					if (parameters[0] == '1') { mode1 = intcode[i + 1]; }
					if (parameters[1] == '1') { mode2 = intcode[i + 2]; }

					if (parameters[2] == '1') { intcode[i + 3] = mode1 + mode2; }
					if (parameters[2] == '0') { intcode[intcode[i + 3]] = mode1 + mode2; }
				}
				catch { Console.WriteLine("failed 1"); }
				break;
			case '2':
				try
				{
					if (parameters[0] == '0') { mode1 = intcode[intcode[i + 1]]; }
					if (parameters[1] == '0') { mode2 = intcode[intcode[i + 2]]; }
					if (parameters[0] == '1') { mode1 = intcode[i + 1]; }
					if (parameters[1] == '1') { mode2 = intcode[i + 2]; }

					if (parameters[2] == '1') { intcode[i + 3] = mode1 * mode2; }
					if (parameters[2] == '0') { intcode[intcode[i + 3]] = mode1 * mode2; }
				}
				catch { Console.WriteLine("failed 2"); }
				break;
			case '3':
				try
				{
					if (phase != -1)
					{
						intcode[intcode[i + 1]] = phase;
						phase = -1;
					}
					else
					{
						while (listQs[phase - 5].Count == 0)
						{
							break;
						}
						intcode[intcode[i + 1]] = listQs[phase - 5].Dequeue();
					}
					i -= 2;
				}
				catch (Exception e) { Console.WriteLine($"failed 3 {phase - 5} {after} {e}"); }
				break;
			case '4':
				try
				{
					listQs[after].Enqueue(intcode[intcode[i + 1]]);
					i -= 2;
				}
				catch { Console.WriteLine("failed 4"); }
				break;
			case '5':
				try
				{
					if (parameters[0] == '0') { mode1 = intcode[intcode[i + 1]]; }
					if (parameters[0] == '1') { mode1 = intcode[i + 1]; }

					if (mode1 != 0)
					{
						if (parameters[1] == '0') { i = intcode[intcode[i + 2]]; }
						if (parameters[1] == '1') { i = intcode[i + 2]; }
						i -= 4;
					}
					else
					{
						i -= 1;
					}

				}
				catch { Console.WriteLine("failed 5"); }
				break;
			case '6':
				try
				{
					if (parameters[0] == '0') { mode1 = intcode[intcode[i + 1]]; }
					if (parameters[0] == '1') { mode1 = intcode[i + 1]; }

					if (mode1 == 0)
					{
						if (parameters[1] == '0') { i = intcode[intcode[i + 2]]; }
						if (parameters[1] == '1') { i = intcode[i + 2]; }
						i -= 4;
					}
					else
					{
						i -= 1;
					}
				}
				catch { Console.WriteLine("failed 6"); }
				break;
			case '7':
				try
				{
					if (parameters[0] == '0') { mode1 = intcode[intcode[i + 1]]; }
					if (parameters[0] == '1') { mode1 = intcode[i + 1]; }
					if (parameters[1] == '0') { mode2 = intcode[intcode[i + 2]]; }
					if (parameters[1] == '1') { mode2 = intcode[i + 2]; }

					if (mode1 < mode2)
					{
						intcode[intcode[i + 3]] = 1;
					}
					else
					{
						intcode[intcode[i + 3]] = 0;
					}
				}
				catch { Console.WriteLine("failed 7"); }
				break;
			case '8':
				try
				{
					if (parameters[0] == '0') { mode1 = intcode[intcode[i + 1]]; }
					if (parameters[0] == '1') { mode1 = intcode[i + 1]; }
					if (parameters[1] == '0') { mode2 = intcode[intcode[i + 2]]; }
					if (parameters[1] == '1') { mode2 = intcode[i + 2]; }

					Console.WriteLine(mode1 + " == " + mode2);

					if (mode1 == mode2)
					{
						intcode[intcode[i + 3]] = 1;
					}
					else
					{
						intcode[intcode[i + 3]] = 0;
					}
					Console.WriteLine(intcode[intcode[i + 2]]);
				}
				catch { Console.WriteLine("failed 8"); }
				break;

		}
	}
	listQs[after].Dequeue().Dump();
}

var dis = new List<List<int>>();
for (var i = 0; i < 43210; i++)
{
	var str = i.ToString();
	if (str.Length == 4) { str = "0" + str; }
	if (Convert.ToBoolean(str.IndexOf('0') + 1) && Convert.ToBoolean(str.IndexOf('1') + 1) && Convert.ToBoolean(str.IndexOf('2') + 1) && Convert.ToBoolean(str.IndexOf('3') + 1) && Convert.ToBoolean(str.IndexOf('4') + 1))
	{
		dis.Add(new List<int>() { (int)Char.GetNumericValue(str[0]), (int)Char.GetNumericValue(str[1]), (int)Char.GetNumericValue(str[2]), (int)Char.GetNumericValue(str[3]), (int)Char.GetNumericValue(str[4]) });
	}
}

var dis2 = new List<List<int>>();
for (var i = 0; i < 98765; i++)
{
	var str = i.ToString();
	if (Convert.ToBoolean(str.IndexOf('5') + 1) && Convert.ToBoolean(str.IndexOf('6') + 1) && Convert.ToBoolean(str.IndexOf('7') + 1) && Convert.ToBoolean(str.IndexOf('8') + 1) && Convert.ToBoolean(str.IndexOf('9') + 1))
	{
		dis.Add(new List<int>() { (int)Char.GetNumericValue(str[0]), (int)Char.GetNumericValue(str[1]), (int)Char.GetNumericValue(str[2]), (int)Char.GetNumericValue(str[3]), (int)Char.GetNumericValue(str[4]) });
	}
}

var highest = 0;

Task.Run(() => doIt(5));
Task.Run(() => doIt(6));
Task.Run(() => doIt(7));
Task.Run(() => doIt(8));
Task.Run(() => doIt(9));