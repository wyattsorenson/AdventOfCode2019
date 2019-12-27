<Query Kind="Statements" />



var data = new List<string[]>();
for (int i = 0; i < 200; i++)
{
	if (i != 100)
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
			"##.#.",
			".####",
			"###.."
			});
	}
}
var data2 = new List<string[]>();
for (int i = 0; i < 200; i++)
{
	if (i != 100)
	{
		data2.Add(new string[5] {
			".....",
			".....",
			".....",
			".....",
			"....."
			});
	}
	else
	{
		data2.Add(new string[5] {
			"##.#.",
			".##..",
			"##.#.",
			".####",
			"###.."
			});
	}
}

var list = new List<string>();

var level = 0;
for (int q = 0; q < 200; q++)
{
	q.Dump();
	for (int m = 0; m < 200; m++)
	{
		var newString = new string[5];
	
		for (var y = 0; y < 5; y++)
		{
			for (var x = 0; x < 5; x++)
			{
				var u = 0;
				var r = 0;
				var d = 0;
				var l = 0;
				try { u = up(y, x, l); } catch { try { u = upL(level); } catch { } }
				try { r = right(y, x, l); } catch { try { r = rightL(level); } catch { } }
				try { d = down(y, x, l); } catch { try { d = downL(level); } catch { } }
				try { l = left(y, x, l); } catch { try { l = leftL(level); } catch { } }
	
	
				var total = u + r + d + l;
	
				if (data[level][y][x] == '#' && total != 1)
				{
					newString[y] += '.';
				}
				else if (data[level][y][x] == '.' && (total == 1 || total == 2))
				{
					newString[y] += '#';
				}
				else
				{
					newString[y] += data[y][x];
				}
			}
		}
	
		data2[level] = newString;
	}
	data = new List<string[]>(data2);
}
var count = 0;
for (int m = 0; m < 200; m++)
{
	data[m].Dump();
	for (var y = 0; y < 5; y++)
	{
		for (var x = 0; x < 5; x++)
		{
			if ((y != 2 && x != 2) && data[m][y][x] == '#')
			{
				count++;
			}
		}
	}
}
count.Dump();

//	current.Dump();

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
		if (data[l][y - 1][x] == '#')
		{
			return 1;
		}
		else
		{
			return 0;
		}
	}
}
int upL(int l)
{
	var r = 0;
	foreach (var s in data[l - 1][4])
	{
		if (s == '#')
		{
			r++;
		}
	}
	return r;
}
int right(int y, int x, int l)
{
	if (y == 2 && x == 1)
	{
		var r = 0;
		foreach (var s in data[level + 1])
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
		if (data[l][y][x + 1] == '#')
		{
			return 1;
		}
		else
		{
			return 0;
		}
	}
}
int rightL(int l)
{
	var r = 0;
	foreach (var s in data[level - 1])
	{
		if (s[0] == '#')
		{
			r++;
		}
	}
	return r;
}
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
		if (data[l][y + 1][x] == '#')
		{
			return 1;
		}
		else
		{
			return 0;
		}
	}
}
int downL(int l)
{
	var r = 0;
	foreach (var s in data[l - 1][0])
	{
		if (s == '#')
		{
			r++;
		}
	}
	return r;
}
int left(int y, int x, int l)
{
	if (y == 2 && x == 3)
	{
		var r = 0;
		foreach (var s in data[level + 1])
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
		if (data[l][y][x - 1] == '#')
		{
			return 1;
		}
		else
		{
			return 0;
		}
	}
}
int leftL(int l)
{
	var r = 0;
	foreach (var s in data[level - 1])
	{
		if (s[4] == '#')
		{
			r++;
		}
	}
	return r;
}