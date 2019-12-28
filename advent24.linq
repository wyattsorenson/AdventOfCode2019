<Query Kind="Statements" />

var levelAmount = 200;
var minutes = 200;
var data = new List<string[]>();

var empty = new string[5] {"","","","",""};

for (int i = 0; i < levelAmount; i++)
{
	if (i != levelAmount / 2)
	{
		data.Add(new string[5] {
			".....",
			".....",
			".....",
			".....",
			"....."
			});
	}
	else
	{
		data.Add(new string[5] {
			"##.#.",
			".##..",
			"##?#.",
			".####",
			"###.."
			});

//		data.Add(new string[5] {
//			"....#",
//			"#..#.",
//			"#.?##",
//			"..#..",
//			"#...."
//			});
	}
}
var data2 = new List<string[]>();
for (int i = 0; i < levelAmount; i++)
{
	data2.Add(new string[5] {
		"",
		"",
		"",
		"",
		""
		});
}

var list = new List<string>();


for (int q = 0; q < minutes; q++) // minutes
{
	q.Dump();
	for (int m = 0; m < levelAmount; m++) // level
	{
		for (var y = 0; y < 5; y++) // row
		{
			for (var x = 0; x < 5; x++) // column
			{
				if (y == 2 && x == 2)
				{
					data2[m][y]  += '?';
				}
				else
				{
					var u = 0;
					var r = 0;
					var d = 0;
					var l = 0;
					try { u = up(y, x, m); } catch { try { u = upL(m); } catch { } }
					try { r = right(y, x, m); } catch { try { r = rightL(m); } catch { } }
					try { d = down(y, x, m); } catch { try { d = downL(m); } catch { } }
					try { l = left(y, x, m); } catch { try { l = leftL(m); } catch { } }

					var total = u + r + d + l;
					if (data[m][y][x] == '#' && total != 1)
					{
						data2[m][y] += '.';
					}
					else if (data[m][y][x] == '.' && (total == 1 || total == 2))
					{
						data2[m][y] += '#';
					}
					else
					{
						data2[m][y] += data[m][y][x];
					}
				}
			}
		}
	}
	data = data2;
	data2 = new List<string[]>();
	for (int i = 0; i < levelAmount; i++)
	{
		data2.Add(new string[5] {
		"",
		"",
		"",
		"",
		""
		});
	}
}
var count = 0;
for (int m = 0; m < levelAmount; m++)
{
//	data[m].Dump($"level: {m}");
	for (var y = 0; y < 5; y++)
	{
		for (var x = 0; x < 5; x++)
		{
			if (data[m][y][x] == '#')
			{
				count++;
			}
		}
	}
}
count.Dump();

int up(int y, int x, int l)
{
	if (y == 3 && x == 2)
	{
		var r = 0;
		foreach (var s in data[l + 1][4])
		{
			if (s == '#')
			{
				r++;
			}
		}
		return r;
	}
	else
	{
		return data[l][y - 1][x] == '#' ? 1 : 0;
	}
}

int upL(int l) =>
	data[l - 1][1][2] == '#' ? 1 : 0;

int right(int y, int x, int l)
{
	if (y == 2 && x == 1)
	{
		var r = 0;
		foreach (var s in data[l + 1])
		{
			if (s[0] == '#')
			{
				r++;
			}
		}
		return r;
	}
	else
	{
		return data[l][y][x + 1] == '#' ? 1 : 0;
	}
}

int rightL(int l) =>
	data[l - 1][2][3] == '#' ? 1 : 0;

int down(int y, int x, int l)
{
	if (y == 1 && x == 2)
	{
		var r = 0;
		foreach (var s in data[l + 1][0])
		{
			if (s == '#')
			{
				r++;
			}
		}
		return r;
	}
	else
	{
		return data[l][y + 1][x] == '#' ? 1 : 0;
	}
}

int downL(int l) =>
	data[l - 1][3][2] == '#' ? 1 : 0;

int left(int y, int x, int l)
{
	if (y == 2 && x == 3)
	{
		var r = 0;
		foreach (var s in data[l + 1])
		{
			if (s[4] == '#')
			{
				r++;
			}
		}
		return r;
	}
	else
	{
		return data[l][y][x - 1] == '#' ? 1 : 0;
	}
}

int leftL(int l) =>
	data[l - 1][2][1] == '#' ? 1 : 0;