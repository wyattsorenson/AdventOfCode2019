<Query Kind="Statements" />

var data = new List<string>(){};
data.Add("###..#.##.####.##..###.#.#..");
data.Add("#..#..###..#.......####.....");
data.Add("#.###.#.##..###.##..#.###.#.");
data.Add("..#.##..##...#.#.###.##.####");
data.Add(".#.##..####...####.###.##...");
data.Add("##...###.#.##.##..###..#..#.");
data.Add(".##..###...#....###.....##.#");
data.Add("#..##...#..#.##..####.....#.");
data.Add(".#..#.######.#..#..####....#");
data.Add("#.##.##......#..#..####.##..");
data.Add("##...#....#.#.##.#..#...##.#");
data.Add("##.####.###...#.##........##");
data.Add("......##.....#.###.##.#.#..#");
data.Add(".###..#####.#..#...#...#.###");
data.Add("..##.###..##.#.##.#.##......");
data.Add("......##.#.#....#..##.#.####");
data.Add("...##..#.#.#.....##.###...##");
data.Add(".#.#..#.#....##..##.#..#.#..");
data.Add("...#..###..##.####.#...#..##");
data.Add("#.#......#.#..##..#...#.#..#");
data.Add("..#.##.#......#.##...#..#.##");
data.Add("#.##..#....#...#.##..#..#..#");
data.Add("#..#.#.#.##..#..#.#.#...##..");
data.Add(".#...#.........#..#....#.#.#");
data.Add("..####.#..#..##.####.#.##.##");
data.Add(".#.######......##..#.#.##.#.");
data.Add(".#....####....###.#.#.#.####");
data.Add("....####...##.#.#...#..#.##.");
//var data = new List<string>(){};
//data.Add("#####");
//data.Add("#####");
//data.Add("#####");
//data.Add("#####");
//data.Add("#####");

var astToSeen = new Dictionary<int[], int>(){};

for(var i = 0; i < data.Count; i++) //for column
{
	for(var j = 0; j < data[i].Length; j++) // for row
	{
		var count = 0;
		if(data[j][i] == '#')
		{
			var m = i;
			var n = j;

			while(j != 0){if(data[n][m--] == '#'){count++; break;}}
			m = i;
			while(j != data.Count){if(data[n][m++] == '#'){count++; break; }}
			m = i;
			while(j != 0){if(data[n--][m] == '#'){count++; break;}}
			n = j;
			while(j != data[i].Length){if(data[n++][m] == '#'){count++; break;}}
			
			var dubs = new List<double>();
			for(var o = 0; o < data.Count; o++)
			{
				for(var p = 0; p < data[i].Length; p++)
				{
					double width = o - i;
					double height = p - j;
					
					var toa = Math.Tan(width/height);
					if(data[p][o] == '#' && (toa > 0.0000000001 || toa < 0.0000000001) && toa != 0)
					{
					
							 if(o <= i && p <= j && !dubs.Contains(toa) ){dubs.Add(toa);}
						else if(o <= i && p >= j && !dubs.Contains(toa) ){dubs.Add(toa);}
						else if(o >= i && p <= j && !dubs.Contains(toa) ){dubs.Add(toa);}
						else if(o >= i && p >= j && !dubs.Contains(toa) ){dubs.Add(toa);}
						if(p ==2 && o ==2){toa.Dump();}
					}
				}
				
			}	
//			Console.WriteLine("******************************************************");
			
//			dubs.Count().Dump();
			count += dubs.Distinct().Count();
//			count.Dump();

			astToSeen.Add(new int[2]{i,j}, count);
		}
		
	}
	Console.WriteLine("******************************************************");
}
astToSeen.Values.Max().Dump();