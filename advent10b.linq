<Query Kind="Statements" />

var data = new List<string>(){};
//data.Add("###..#.##.####.##..###.#.#..");
//data.Add("#..#..###..#.......####.....");
//data.Add("#.###.#.##..###.##..#.###.#.");
//data.Add("..#.##..##...#.#.###.##.####");
//data.Add(".#.##..####...####.###.##...");
//data.Add("##...###.#.##.##..###..#..#.");
//data.Add(".##..###...#....###.....##.#");
//data.Add("#..##...#..#.##..####.....#.");
//data.Add(".#..#.######.#..#..####....#");
//data.Add("#.##.##......#..#..####.##..");
//data.Add("##...#....#.#.##.#..#...##.#");
//data.Add("##.####.###...#.##........##");
//data.Add("......##.....#.###.##.#.#..#");
//data.Add(".###..#####.#..#...#...#.###");
//data.Add("..##.###..##.#.##.#.##......");
//data.Add("......##.#.#....#..##.#.####");
//data.Add("...##..#.#.#.....##.###...##");
//data.Add(".#.#..#.#....##..##.#..#.#..");
//data.Add("...#..###..##.####.#...#..##");
//data.Add("#.#......#.#..##..#...#.#..#");
//data.Add("..#.##.#......#.##...#..#.##");
//data.Add("#.##..#....#...#.##..#..#..#");
//data.Add("#..#.#.#.##..#..#.#.#...##..");
//data.Add(".#...#.........#..#....#.#.#");
//data.Add("..####.#..#..##.####.#.##.##");
//data.Add(".#.######......##..#.#.##.#.");
//data.Add(".#....####....###.#.#.#.####");
//data.Add("....####...##.#.#...#..#.##.");

data.Add(".#....#####...#..");
data.Add("##...##.#####..##");
data.Add("##...#...#.#####.");
data.Add("..#.....X...###..");
data.Add("..#.#.....#....##");

int doIt()
{
	var astToSeen = new List<int>(){};
	
	for(var i = 0; i < data.Count; i++) //for column
	{
		for(var j = 0; j < data[i].Length; j++) // for row
		{
			if(data[j][i] == '#')
			{			
				var dubs = new List<double>();
				for(var o = 0; o < data.Count; o++)
				{
					for(var p = 0; p < data[i].Length; p++)
					{
						if(data[p][o] == '#')
						{
							double width = o - i;
							double height = p - j;
							dubs.Add(Math.Atan2(width,height) * 180 / Math.PI);
						}
					}
				}	
				astToSeen.Add(dubs.Distinct().ToList().Count());
			}
		}
	}
	return astToSeen.Max();
}

void doIt2(){
//	var j = 19;
//	var i = 22;
	
	var j = 3;
	var i = 8;	
	var dubs = new List<double>();
	var dict = new Dictionary<double, int>(){};
	for(var o = 0; o < data.Count; o++)
	{
//		o.Dump("o");
		for(var p = 0; p < data[0].Length; p++)
		{
//			p.Dump("p");
			if(data[o][p] == '#')
			{
				double width = o - i;
				double height = p - j;
				Console.WriteLine(Math.Atan2(width,height) * 180 / Math.PI);x
				if(p != j && o != i)
				{
					dubs.Add(Math.Atan2(width,height) * 180 / Math.PI);
					if(dict.ContainsKey(Math.Atan2(width,height) * 180 / Math.PI))
					{
						dict[Math.Atan2(width,height) * 180 / Math.PI]++;
					}
					else
					{
						dict.Add(Math.Atan2(width,height) * 180 / Math.PI, 1);
					}
					if(Math.Atan2(width,height) * 180 / Math.PI < -129.8 && Math.Atan2(width,height) * 180 / Math.PI > -129.81)
					{
//						p.Dump();
//						o.Dump();
					}
				}
			}
		}
	}	
	List<double> ordered = dubs.ToList().OrderBy(x => x).ToList();
	ordered.Dump();
	var at = 0.0;
	var previous = 0;
	int t = 0;
	var count = 0;
	for(var q = 11; count < 9; q--)
	{
		if(dict[ordered[q]] > 0 && previous != ordered[q])
		{
			dict[ordered[q]]--;
			at = ordered[q];
			count++;
		}
		if(q == 0){q = 36;}
	}
	
	at.Dump();
	dict[at].Dump();	
}

//int bresNumber = 69;
//
//bresNumber = doIt();
doIt2();