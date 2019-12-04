<Query Kind="Statements" />

var TheQualifiers1 = new List<string>();
var TheQualifiers2 = new List<string>();

for (int i = 108457; i <= 562041; i++)
{
	string str = i.ToString();
	if (ascend(str) && aside(str))
	{
		TheQualifiers1.Add(str);
		if (One(str) | Two(str) | Three(str) | Four(str) | Five(str))
			TheQualifiers2.Add(str);
	}
}

TheQualifiers1.Count().Dump();
TheQualifiers2.Count().Dump();

bool ascend(string str)
{
	for (var j = 0; j < str.Length - 1; j++)
		if (!((int)str[j] <= (int)str[j + 1])) return false;
	return true;
}

bool aside(string str)
{
	for (var j = 0; j < str.Length - 1; j++)
		if ((int)str[j] == (int)str[j + 1]) return true;
	return false;
}

bool One(string str) =>
	((int)str[0] == (int)str[1] && (int)str[1] != (int)str[2]);

bool Two(string str) =>
	((int)str[2] == (int)str[1] && (int)str[1] != (int)str[3] && (int)str[1] != (int)str[0]);

bool Three(string str) =>
	((int)str[3] == (int)str[2] && (int)str[2] != (int)str[4] && (int)str[2] != (int)str[1]);

bool Four(string str) =>
	((int)str[4] == (int)str[3] && (int)str[3] != (int)str[5] && (int)str[3] != (int)str[2]);

bool Five(string str) =>
	((int)str[5] == (int)str[4] && (int)str[4] != (int)str[3]);