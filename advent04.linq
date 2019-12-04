<Query Kind="Statements" />

var TheQualifiers = new List<string>();
var pattern1 = "(0){3,6}|(1){3,6}|(2){3,6}|(3){3,6}|(4){3,6}|(5){3,6}|(6){3,6}|(7){3,6}|(8){3,6}|(9){3,6}";


for(int i = 108457; i <= 562041; i++)
{
	string str = i.ToString();
	var isAscending = ascend(str);
	var isAside = aside(str);
		
	if(isAscending && isAside)
	{
		if(One(str) | Two(str) | Three(str) | Four(str) | Five(str))
		{
			Console.WriteLine(str);
			TheQualifiers.Add(str);	
		}
    }
}
TheQualifiers.Count().Dump();

bool ascend(string str)
{
	for(var j = 0; j < str.Length -1; j++)
	{
		var previous = (int)str[j];
		var current = (int)str[j+1];
		if(previous <= current)
		{
		}
		else
		{
			return false;
		}
	}
	return true;
}

bool aside(string str)
{
	for(var j = 0; j < str.Length -1; j++)
	{
		var previous = (int)str[j];
		var current = (int)str[j+1];
		if(previous == current)
		{
			return true;
		}
	}
	return false;
}

bool One(string str)
{
		var previous = (int)str[0];
		var current = (int)str[1];
		var next = (int)str[2];
		
		if(previous == current && current != next)
		{
			return true;
		}
		else
		{
			return false;
		}
}

bool Two(string str)
{
		var previous = (int)str[0];
		var current = (int)str[1];
		var next = (int)str[2];
		var next2 = (int)str[3];
		
		if(next == current && current != next2 && current != previous)
		{
			return true;
		}
		else
		{
			return false;
		}
}
bool Three(string str)
{
		var previous = (int)str[1];
		var current = (int)str[2];
		var next = (int)str[3];
		var next2 = (int)str[4];
		
		if(next == current && current != next2 && current != previous)
		{
			return true;
		}
		else
		{
			return false;
		}
}
bool Four(string str)
{
		var previous = (int)str[2];
		var current = (int)str[3];
		var next = (int)str[4];
		var next2 = (int)str[5];
		
		if(next == current && current != next2 && current != previous)
		{
			return true;
		}
		else
		{
			return false;
		}
}
bool Five(string str)
{
		var previous = (int)str[3];
		var current = (int)str[4];
		var next = (int)str[5];
		
		if(next == current && current != previous)
		{
			return true;
		}
		else
		{
			return false;
		}
}