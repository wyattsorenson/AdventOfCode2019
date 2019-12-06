<Query Kind="Statements" />

void doIt()
{
	int mode1 = 0;
	int mode2 = 0;
	int mode3 = 0;
	var input = 1;
	var output = 0;
	var parameters = new char[3];

	//	for (int w = 0; w < 100; w++)
	//	{
	//		for (int d = 0; d < 100; d++)
	//		{
	var intcode = new List<int>() { 3, 225, 1, 225, 6, 6, 1100, 1, 238, 225, 104, 0, 1002, 114, 46, 224, 1001, 224, -736, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 3, 224, 1, 223, 224, 223, 1, 166, 195, 224, 1001, 224, -137, 224, 4, 224, 102, 8, 223, 223, 101, 5, 224, 224, 1, 223, 224, 223, 1001, 169, 83, 224, 1001, 224, -90, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 2, 224, 1, 224, 223, 223, 101, 44, 117, 224, 101, -131, 224, 224, 4, 224, 1002, 223, 8, 223, 101, 5, 224, 224, 1, 224, 223, 223, 1101, 80, 17, 225, 1101, 56, 51, 225, 1101, 78, 89, 225, 1102, 48, 16, 225, 1101, 87, 78, 225, 1102, 34, 33, 224, 101, -1122, 224, 224, 4, 224, 1002, 223, 8, 223, 101, 7, 224, 224, 1, 223, 224, 223, 1101, 66, 53, 224, 101, -119, 224, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 5, 224, 1, 223, 224, 223, 1102, 51, 49, 225, 1101, 7, 15, 225, 2, 110, 106, 224, 1001, 224, -4539, 224, 4, 224, 102, 8, 223, 223, 101, 3, 224, 224, 1, 223, 224, 223, 1102, 88, 78, 225, 102, 78, 101, 224, 101, -6240, 224, 224, 4, 224, 1002, 223, 8, 223, 101, 5, 224, 224, 1, 224, 223, 223, 4, 223, 99, 0, 0, 0, 677, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1105, 0, 99999, 1105, 227, 247, 1105, 1, 99999, 1005, 227, 99999, 1005, 0, 256, 1105, 1, 99999, 1106, 227, 99999, 1106, 0, 265, 1105, 1, 99999, 1006, 0, 99999, 1006, 227, 274, 1105, 1, 99999, 1105, 1, 280, 1105, 1, 99999, 1, 225, 225, 225, 1101, 294, 0, 0, 105, 1, 0, 1105, 1, 99999, 1106, 0, 300, 1105, 1, 99999, 1, 225, 225, 225, 1101, 314, 0, 0, 106, 0, 0, 1105, 1, 99999, 1107, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 329, 101, 1, 223, 223, 1108, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 344, 101, 1, 223, 223, 8, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 359, 1001, 223, 1, 223, 1007, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 374, 101, 1, 223, 223, 1008, 677, 677, 224, 1002, 223, 2, 223, 1005, 224, 389, 1001, 223, 1, 223, 1108, 677, 226, 224, 1002, 223, 2, 223, 1006, 224, 404, 1001, 223, 1, 223, 1007, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 419, 1001, 223, 1, 223, 1107, 677, 226, 224, 1002, 223, 2, 223, 1006, 224, 434, 101, 1, 223, 223, 108, 677, 677, 224, 1002, 223, 2, 223, 1005, 224, 449, 1001, 223, 1, 223, 1107, 677, 677, 224, 102, 2, 223, 223, 1005, 224, 464, 1001, 223, 1, 223, 108, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 479, 1001, 223, 1, 223, 1008, 226, 226, 224, 102, 2, 223, 223, 1005, 224, 494, 101, 1, 223, 223, 108, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 509, 1001, 223, 1, 223, 8, 677, 226, 224, 1002, 223, 2, 223, 1006, 224, 524, 101, 1, 223, 223, 7, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 539, 101, 1, 223, 223, 7, 677, 226, 224, 102, 2, 223, 223, 1006, 224, 554, 1001, 223, 1, 223, 7, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 569, 101, 1, 223, 223, 107, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 584, 101, 1, 223, 223, 1108, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 599, 1001, 223, 1, 223, 1008, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 614, 1001, 223, 1, 223, 8, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 629, 1001, 223, 1, 223, 107, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 644, 101, 1, 223, 223, 1007, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 659, 101, 1, 223, 223, 107, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 674, 1001, 223, 1, 223, 4, 223, 99, 226};
			//			intcode[1] = w;
//			intcode[2] = d;
			for (int i = 0; intcode[i] != 99; i += 4)
			{
				Console.WriteLine("**********************************************************************");
				intcode[i].Dump("Full Instruciton:");
				i.Dump("Instruction address on intcode list");
				var str = intcode[i].ToString();

				// 1 == add 2== multiply 3 == input into parameter 4 == output from parameter
				char opcode = str[str.Length - 1];
				opcode.Dump("Opcode");

				//0 == position mode go address 1 == immediate mode use literal
				if (str.Length > 2)
				{
					str = str.Substring(str.Length - 2);
					char[] charArray = str.ToCharArray();
					Array.Reverse(charArray);
					str = charArray.ToString();
					try { parameters[0] = str[0]; } catch { parameters[0] = '0'; }
					try { parameters[1] = str[1]; } catch { parameters[1] = '0'; }
					try { parameters[2] = str[2]; } catch { parameters[2] = '0'; }
					parameters.Dump("parameters:");
				}

				switch (opcode)
				{
					case '1':
						Console.WriteLine("11111");
						try
						{
							if (parameters[0] == '0') { mode1 = intcode[intcode[i + 1]]; }
							if (parameters[1] == '0') { mode2 = intcode[intcode[i + 2]]; }
							if (parameters[2] == '0') { mode3 = intcode[intcode[i + 3]]; }
							if (parameters[0] == '1') { mode1 = intcode[i + 1]; }
							if (parameters[1] == '1') { mode2 = intcode[i + 2]; }
							if (parameters[2] == '1') { mode3 = intcode[i + 3]; }

							mode3 = mode1 + mode2;
							Console.WriteLine(mode3 + " " + mode1 + " " + mode2);

						}
						catch {Console.WriteLine("failed 1"); }
						break;
					case '2':
						Console.WriteLine("22222");
						try
						{
							if (parameters[0] == '0') { mode1 = intcode[intcode[i + 1]]; }
							if (parameters[1] == '0') { mode2 = intcode[intcode[i + 2]]; }
							if (parameters[2] == '0') { mode3 = intcode[intcode[i + 3]]; }
							if (parameters[0] == '1') { mode1 = intcode[i + 1]; }
							if (parameters[1] == '1') { mode2 = intcode[i + 2]; }
							if (parameters[2] == '1') { mode3 = intcode[i + 3]; }

							mode3 = mode1 * mode2;
							Console.WriteLine(mode3 + " " + mode1 + " " + mode2);

						}
						catch {Console.WriteLine("failed 2"); }
						break;
					case '3':
						Console.WriteLine("33333");
						try
						{
							intcode[intcode[i + 1]] = input;
							Console.WriteLine(intcode[intcode[i + 1]] + " " + input);
							i -= 2;
						}
						catch {Console.WriteLine("failed 3"); }
						break;
					case '4':
						Console.WriteLine("44444");
						try
						{
							output = intcode[intcode[i + 1]];
							Console.WriteLine(output + " " + intcode[intcode[i + 1]]);
							i -= 2;
						}
						catch {Console.WriteLine("failed 4"); }
						break;
				}
			}
			//		if(intcode[1] == 12 && intcode[2] == 2){Console.WriteLine(intcode[0]);}
			//		if(intcode[0] == 19690720){
			//			Console.WriteLine(100 * intcode[1] +  intcode[2]);
			//			return;
			//		}
			Console.WriteLine(output);
//		} for1
//	} for2
}
doIt();