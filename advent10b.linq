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
data.Add("#.#......#.#..##..#...X.#..#");
data.Add("..#.##.#......#.##...#..#.##");
data.Add("#.##..#....#...#.##..#..#..#");
data.Add("#..#.#.#.##..#..#.#.#...##..");
data.Add(".#...#.........#..#....#.#.#");
data.Add("..####.#..#..##.####.#.##.##");
data.Add(".#.######......##..#.#.##.#.");
data.Add(".#....####....###.#.#.#.####");
data.Add("....####...##.#.#...#..#.##.");

//data.Add(".#..##.###...#######");
//data.Add("##.############..##.");
//data.Add(".#.######.########.#");
//data.Add(".###.#######.####.#.");
//data.Add("#####.##.#.##.###.##");
//data.Add("..#####..#.#########");
//data.Add("####################");
//data.Add("#.####....###.#.#.##");
//data.Add("##.#################");
//data.Add("#####.##.###..####..");
//data.Add("..######..##.#######");
//data.Add("####.##.####...##..#");
//data.Add(".#####..#.######.###");
//data.Add("##...#.####X#####...");
//data.Add("#.##########.#######");
//data.Add(".####.#.###.###.#.##");
//data.Add("....##.##.###..#####");
//data.Add(".#.#.###########.###");
//data.Add("#.#.#.#####.####.###");
//data.Add("###.##.####.##.#..##");

//data.Add(".#....#####...#..");
//data.Add("##...##.#####..##");
//data.Add("##...#...#.#####.");
//data.Add("..#.....X...###..");
//data.Add("..#.#.....#....##");

//data.Add(".#..#.");
//data.Add(".#.#..");
//data.Add(".##...");
//data.Add("#X....");
//data.Add("#...#.");

var j = 0;
var i = 0;

for(var ii =  0; ii < data.Count; ii++)
{
	for(var jj = 0; jj < data[0].Length; jj++)
	{
		if(data[ii][jj] == 'X')
		{
			j = jj;
			i = ii;
		}
	}
}

//i.Dump("i");
//j.Dump("j");

//int doIt()
//{
//	var astToSeen = new List<int>(){};
//	
//	for(var i = 0; i < data.Count; i++) //for column
//	{
//		for(var j = 0; j < data[i].Length; j++) // for row
//		{
//			if(data[j][i] == '#')
//			{			
//				var dubs = new List<double>();
//				for(var o = 0; o < data.Count; o++)
//				{
//					for(var p = 0; p < data[i].Length; p++)
//					{
//						if(data[p][o] == '#')
//						{
//							double width = o - i;
//							double height = p - j;
//							dubs.Add(Math.Atan2(width,height) * 180 / Math.PI);
//						}
//					}
//				}	
//				astToSeen.Add(dubs.Distinct().ToList().Count());
//			}
//		}
//	}
//	return astToSeen.Max();
//}



double doIt2(double val){
	var dubs = new List<double>();
	var dict = new Dictionary<double, int>(){};
	for(var p = 0; p < data[0].Length; p++)
	{
		for(var o = 0; o < data.Count; o++)
		{
			if(data[o][p] == '#')
			{
				double width = o - i;
				double height = p - j;
//				Console.WriteLine(Math.Atan2(height,width) * 180 / Math.PI);
				if(p != j || o != i)
				{
						dubs.Add(Math.Atan2(height,width) * 180 / Math.PI);
						if(dict.ContainsKey(Math.Atan2(height,width) * 180 / Math.PI))
						{
							dict[Math.Atan2(height,width) * 180 / Math.PI]++;
						}
						else
						{
							dict.Add(Math.Atan2(height,width) * 180 / Math.PI, 1);
						}
	//					(Math.Atan2(height,width) * 180 / Math.PI).Dump();
						if(Math.Atan2(height,width) * 180 / Math.PI == val)
						{
							"".Dump($"{p}, {o}");
//							o.Dump();
						}
				}
			}
		}
	}	
	List<double> ordered = dubs.Distinct().ToList().OrderByDescending(xx => xx).ToList();
	
//	dict.Dump("dict");
//	ordered.Dump();
	var ttt = 0.0;
	var iter = 0;
	for(var lasering = 0; lasering < 200; lasering++)
	{
		 while(dict[ordered[iter]] == 0)
		 {
		 	if(iter == ordered.Count- 1)
			{
				iter = 0;
			}
			else
			{
				iter++;
			}
		 }
		 dict[ordered[iter]]--;
		 ttt = ordered[iter];
		 if(iter == ordered.Count -1)
		{
			iter = 0;
		}
		else
		{
			iter++;
		}
//		iter.Dump();
	}	
	return ttt;
}


doIt2(doIt2(3456.0)).Dump();

