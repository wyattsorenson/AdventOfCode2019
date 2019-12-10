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

var angles = new List<double>() {};
var astToSeen = new Dictionary<int[], int>(){};

for(var i = 0; i < data.Count; i++) 
{
	for(var j = 0; j < data[i].Length; j++) // date[j][i] check what each see
	{
		var count = 0;
		if(data[j][i] == '#')
		{
			var m = i;
			var n = j; // data[n][m] check udlr

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
				for(var p = 0; p < data[i].Length; p++) // data[p][o] check if seen
				{
					double width = o - i;
					double height = p - j;
					
					var toa = width/height;
					if(data[p][o] == '#' && (toa > 0.0000000001 || toa < -0.0000000001) && toa != 0 && width != 0 && height != 0)
					{
							 if(p <= i && o <= j && !dubs.Contains(10 + toa) ){dubs.Add(10 + toa); if(j ==2 && i ==2){angles.Add(10 + toa);}}
						else if(p <= i && o >= j && !dubs.Contains(20 + toa) ){dubs.Add(20 + toa); if(j ==2 && i ==2){angles.Add(20 + toa);}}
						else if(p >= i && o <= j && !dubs.Contains(30 + toa) ){dubs.Add(30 + toa); if(j ==2 && i ==2){angles.Add(30 + toa);}}
						else if(p >= i && o >= j && !dubs.Contains(40 + toa) ){dubs.Add(40 + toa); if(j ==2 && i ==2){angles.Add(40 + toa);}}
//						if(j ==2 && i ==2){toa.Dump();}
					}
				}
				
			}	
//			Console.WriteLine("******************************************************");
			
			dubs.Count().Dump();
			count += dubs.Distinct().Count();
//			count.Dump();

			astToSeen.Add(new int[2]{i,j}, count);
		}
	}
//	Console.WriteLine("******************************************************");
}
astToSeen.Values.Max().Dump();

angles.OrderBy(x => x).Dump();