<Query Kind="Statements" />

int doIt(int r, int p)
{
	int mode1 = 0;
	int phase = p;
	int mode2 = 0;
	var input = r;
	var output = 0;
	var parameters = new char[3];
	var intcode =  new List<int>(){3,8,1001,8,10,8,105,1,0,0,21,34,51,64,73,98,179,260,341,422,99999,3,9,102,4,9,9,1001,9,4,9,4,9,99,3,9,1001,9,4,9,1002,9,3,9,1001,9,5,9,4,9,99,3,9,101,5,9,9,102,5,9,9,4,9,99,3,9,101,5,9,9,4,9,99,3,9,1002,9,5,9,1001,9,3,9,102,2,9,9,101,5,9,9,1002,9,2,9,4,9,99,3,9,1001,9,1,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,2,9,4,9,3,9,1001,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,101,1,9,9,4,9,3,9,101,1,9,9,4,9,3,9,102,2,9,9,4,9,3,9,101,2,9,9,4,9,99,3,9,101,1,9,9,4,9,3,9,1001,9,1,9,4,9,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,101,2,9,9,4,9,3,9,101,1,9,9,4,9,3,9,101,1,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,2,9,4,9,99,3,9,101,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,1001,9,2,9,4,9,3,9,1001,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,1001,9,1,9,4,9,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,101,2,9,9,4,9,99,3,9,1002,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,101,2,9,9,4,9,3,9,1001,9,2,9,4,9,99,3,9,1001,9,1,9,4,9,3,9,101,1,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,2,9,4,9,3,9,1001,9,1,9,4,9,3,9,101,1,9,9,4,9,3,9,102,2,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,2,9,4,9,99};

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
					str = str.Substring(0, str.Length - 2);
					char[] charArray = str.ToCharArray();
					Array.Reverse(charArray);
					str = new string( charArray );

					try { parameters[0] = str[0]; } catch { parameters[0] = '0'; }
					try { parameters[1] = str[1]; } catch { parameters[1] = '0'; }
					try { parameters[2] = str[2]; } catch { parameters[2] = '0'; }
					parameters.Dump("parameters:");
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
						catch {Console.WriteLine("failed 1"); }
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
						catch {Console.WriteLine("failed 2"); }
						break;
					case '3':
						try
						{
							if(phase != -1)
							{
								intcode[intcode[i + 1]] = phase;
							}
							else
							{
								intcode[intcode[i + 1]] = input;
							}
							Console.WriteLine(intcode[intcode[i + 1]] + " " + input);
							i -= 2;
						}
						catch {Console.WriteLine("failed 3"); }
						break;
					case '4':
						try
						{
							output = intcode[intcode[i + 1]];
							Console.WriteLine(output + " " + intcode[intcode[i + 1]]);
							i -= 2;
						}
						catch {Console.WriteLine("failed 4"); }
						break;
					case '5':
						try
						{
							if (parameters[0] == '0') { mode1 = intcode[intcode[i + 1]]; }
							if (parameters[0] == '1') { mode1 = intcode[i + 1];}
							
							if(mode1 != 0)
							{
								if (parameters[1] == '0') { i = intcode[intcode[i + 2]];}
							    if (parameters[1] == '1') {i = intcode[i + 2];}
								i -= 4;
							}
							else
							{
								i -= 1;
							}
							
						}
						catch {Console.WriteLine("failed 5"); }
						break;
					case '6':
						try
						{
							if (parameters[0] == '0') { mode1 = intcode[intcode[i + 1]]; }
							if (parameters[0] == '1') { mode1 = intcode[i + 1];}
							
							if(mode1 == 0)
							{
								if (parameters[1] == '0') { i = intcode[intcode[i + 2]];}
							    if (parameters[1] == '1') {i = intcode[i + 2];}
								i -= 4;
							}
							else
							{
								i -= 1;
							}
						}
						catch {Console.WriteLine("failed 6"); }
						break;
					case '7':
						try
						{
							if (parameters[0] == '0') { mode1 = intcode[intcode[i + 1]]; }
							if (parameters[0] == '1') { mode1 = intcode[i + 1];}
							if (parameters[1] == '0') { mode2 = intcode[intcode[i + 2]]; }
							if (parameters[1] == '1') { mode2 = intcode[i + 2];}
							
							if(mode1 < mode2)
							{
								intcode[intcode[i + 3]] = 1;
							}
							else
							{
								intcode[intcode[i + 3]] = 0;
							}
						}
						catch {Console.WriteLine("failed 7"); }
						break;
					case '8':
						try
						{
							if (parameters[0] == '0') { mode1 = intcode[intcode[i + 1]]; }
							if (parameters[0] == '1') { mode1 = intcode[i + 1];}
							if (parameters[1] == '0') { mode2 = intcode[intcode[i + 2]]; }
							if (parameters[1] == '1') { mode2 = intcode[i + 2];}
							
							Console.WriteLine(mode1 + " == " + mode2);
							
							if(mode1 == mode2)
							{
								intcode[intcode[i + 3]] = 1;
							}
							else
							{
								intcode[intcode[i + 3]] = 0;
							}
							Console.WriteLine(intcode[intcode[i + 2]]); 
						}
						catch {Console.WriteLine("failed 8"); }
						break;
						
				}
			}
			return output;
}
var o1 = doIt(0);
var o2 = doIt(o1);
var o3 = doIt(o2);
var o4 = doIt(o3);
var o5 = doIt(o4);


o1.Dump("11111");
o2.Dump("22222");
o3.Dump("33333");
o4.Dump("44444");
o5.Dump("44444");