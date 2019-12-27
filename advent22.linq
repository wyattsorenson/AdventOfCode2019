<Query Kind="Statements" />

var commands = new List<string>();
commands.Add("deal into new stack");
commands.Add("deal with increment 65");
commands.Add("cut -850");
commands.Add("deal with increment 73");
commands.Add("cut -691");
commands.Add("deal with increment 59");
commands.Add("cut 10000");
commands.Add("deal with increment 72");
commands.Add("deal into new stack");
commands.Add("cut -7966");
commands.Add("deal with increment 63");
commands.Add("cut 1076");
commands.Add("deal with increment 33");
commands.Add("cut -7818");
commands.Add("deal with increment 35");
commands.Add("cut 4420");
commands.Add("deal with increment 35");
commands.Add("cut -4594");
commands.Add("deal with increment 10");
commands.Add("cut -8389");
commands.Add("deal into new stack");
commands.Add("deal with increment 2");
commands.Add("cut -3087");
commands.Add("deal into new stack");
commands.Add("cut 3795");
commands.Add("deal with increment 27");
commands.Add("cut -9961");
commands.Add("deal with increment 63");
commands.Add("cut -3494");
commands.Add("deal with increment 43");
commands.Add("cut -1920");
commands.Add("deal with increment 58");
commands.Add("cut 3436");
commands.Add("deal with increment 29");
commands.Add("cut 6173");
commands.Add("deal with increment 27");
commands.Add("cut 5631");
commands.Add("deal into new stack");
commands.Add("cut -6605");
commands.Add("deal with increment 19");
commands.Add("cut 5337");
commands.Add("deal with increment 7");
commands.Add("cut 6315");
commands.Add("deal into new stack");
commands.Add("deal with increment 28");
commands.Add("deal into new stack");
commands.Add("deal with increment 35");
commands.Add("deal into new stack");
commands.Add("cut -6216");
commands.Add("deal with increment 58");
commands.Add("deal into new stack");
commands.Add("deal with increment 16");
commands.Add("cut 7413");
commands.Add("deal into new stack");
commands.Add("cut 5449");
commands.Add("deal into new stack");
commands.Add("cut -3801");
commands.Add("deal with increment 35");
commands.Add("cut -6555");
commands.Add("deal with increment 41");
commands.Add("cut 7341");
commands.Add("deal with increment 48");
commands.Add("deal into new stack");
commands.Add("deal with increment 49");
commands.Add("cut 8059");
commands.Add("deal with increment 16");
commands.Add("cut 9144");
commands.Add("deal with increment 45");
commands.Add("deal into new stack");
commands.Add("cut 3195");
commands.Add("deal with increment 2");
commands.Add("cut -5432");
commands.Add("deal with increment 22");
commands.Add("cut -7629");
commands.Add("deal with increment 70");
commands.Add("cut -4118");
commands.Add("deal with increment 53");
commands.Add("deal into new stack");
commands.Add("deal with increment 30");
commands.Add("cut 4189");
commands.Add("deal with increment 19");
commands.Add("cut -9197");
commands.Add("deal with increment 55");
commands.Add("cut -347");
commands.Add("deal into new stack");
commands.Add("cut 4040");
commands.Add("deal with increment 34");
commands.Add("cut -2743");
commands.Add("deal into new stack");
commands.Add("cut -6206");
commands.Add("deal with increment 48");
commands.Add("cut -7099");
commands.Add("deal with increment 75");
commands.Add("cut -9572");
commands.Add("deal with increment 41");
commands.Add("cut 7531");
commands.Add("deal with increment 59");
commands.Add("deal into new stack");
commands.Add("cut -5");
commands.Add("deal into new stack");

//commands.Add("cut 6");
//commands.Add("deal with increment 7");
//commands.Add("deal into new stack");
//
//commands.Add("deal with increment 7");
//commands.Add("deal with increment 9");
//commands.Add("cut -2");

//commands.Add("deal into new stack");
//commands.Add("cut -2");
//commands.Add("deal with increment 7");
//commands.Add("cut 8");
//commands.Add("cut -4");
//commands.Add("deal with increment 7");
//commands.Add("cut 3");
//commands.Add("deal with increment 9");
//commands.Add("deal with increment 3");
//commands.Add("cut -1");

IEnumerable<long> RangeL(long start, long count)
{
	var end = start + count;
	for (var current = start; current < end; ++current)
	{
		yield return current;
	}
}

var size = 119315717514047;
var list = RangeL(0, size);
var stack = new LinkedList<long>(list);




var n = (long)0;
foreach (var command in commands)
{
	var c = command.Split(' ');
	switch (c[0])
	{
		case "cut":
			n = int.Parse(c[1]);
			if (n > 0)
			{
				for (var i = 0; i < n; i++)
				{
					stack.AddLast(stack.First.Value);
					stack.RemoveFirst();
				}
			}
			else
			{
				for (var i = 0; i < Math.Abs(n); i++)
				{
					stack.AddFirst(stack.Last.Value);
					stack.RemoveLast();
				}
			}
			break;
		case "deal":
			if (c[1] == "into")
			{
				var stack44 = new LinkedList<long>();
				foreach (var s in stack)
				{
					stack44.AddFirst(s);
				}
				stack = new LinkedList<long>(stack44);
			}
			else if (c[1] == "with")
			{
				var a = new long[size];
				n = long.Parse(c[c.Count() - 1]);
				var list2 = new List<long>(stack);

				for (long t = 0; t < stack.Count(); t++)
				{
					a[(t * n) % size] = list2[t];
				}
				stack = new LinkedList<long>(a);
			}
			break;
		default:
			break;
	}
}
if (stack.Count > 2019) { stack.ToList().IndexOf(2019).Dump();}
stack.ToList().Dump();