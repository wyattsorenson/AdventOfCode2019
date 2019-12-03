<Query Kind="Statements" />

var dict1 = new Dictionary<int[],int[]>();
var dict2 = new Dictionary<int[], int[]>();
var list = new List<int[]>();
var current = new int[] {0,0};
var count = 0;

//assign current through switch
count++;
//wire1
if(!dict1.ContainsKey(new int[] {current[0], current[1] }))
{
	dict1.Add(new int[] {current[0], current[1] }, new int[] {1, count})
}

//wire2
if (!dict1.ContainsKey(new int[] { current[0], current[1] })) //if untouched by 1
{
	if (!dict2.ContainsKey(new int[] { current[0], current[1] })) //untouched by 2
	{
		dict2.Add(new int[] { current[0], current[1] }, new int[] { 2, count })
	}
}
else
{
	if (!dict2.ContainsKey(new int[] { current[0], current[1] })) //untouched by 2
	{
		dict1.Add(new int[] { current[0], current[1] }, new int[] { 3, count })
		list.Add(new int[] {current[0], current[1]});
	}
}

foreach(var l in list)
{
	Console.WriteLine(l[0] + l[2]);
}