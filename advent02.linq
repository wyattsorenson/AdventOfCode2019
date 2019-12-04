<Query Kind="Statements" />

void doIt(){
List<int> intcode;
for(int w = 0; w < 100; w++){
	for(int d = 0; d < 100; d++){
		intcode = new List<int>(){1,12,2,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,10,19,1,6,19,23,1,10,23,27,2,27,13,31,1,31,6,35,2,6,35,39,1,39,5,43,1,6,43,47,2,6,47,51,1,51,5,55,2,55,9,59,1,6,59,63,1,9,63,67,1,67,10,71,2,9,71,75,1,6,75,79,1,5,79,83,2,83,10,87,1,87,5,91,1,91,9,95,1,6,95,99,2,99,10,103,1,103,5,107,2,107,6,111,1,111,5,115,1,9,115,119,2,119,10,123,1,6,123,127,2,13,127,131,1,131,6,135,1,135,10,139,1,13,139,143,1,143,13,147,1,5,147,151,1,151,2,155,1,155,5,0,99,2,0,14,0};;
		intcode[1] = w;
		intcode[2] = d;
		for(int i = 0; intcode[i] != 99; i += 4){
			int opcode = intcode[i];
			switch (opcode)
			{
			 case 1:
			 	try{intcode[intcode[i+3]] = intcode[intcode[i+1]] + intcode[intcode[i+2]];}catch{}
			    break;
			 case 2:
			 	try{intcode[intcode[i+3]] = intcode[intcode[i+1]] * intcode[intcode[i+2]];}catch{}
			    break; 
			}
		}
		if(intcode[1] == 12 && intcode[2] == 2){Console.WriteLine(intcode[0]);}
		if(intcode[0] == 19690720){
			Console.WriteLine(100 * intcode[1] +  intcode[2]);
			return;
		}
	}
}
}