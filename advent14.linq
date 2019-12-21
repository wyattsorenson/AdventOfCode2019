<Query Kind="Statements" />

var rules = new List<string>();
//rules.Add("1 WDKW, 2 DWRH, 6 VNMV, 2 HFHL, 55 GJHX, 4 NSDBV, 15 KLJMS, 17 KZDJ => 1 FUEL");
//rules.Add("3 HGCR, 9 TKRT => 8 ZBLC");
//rules.Add("1 MZQLG, 12 RPLCK, 8 PDTP => 8 VCFX");
//rules.Add("3 ZBLC, 19 VFZX => 1 SJQL");
//rules.Add("1 CRPGK => 4 TPRT");
//rules.Add("7 HGCR, 4 TGCW, 1 VFZX => 9 JBPHS");
//rules.Add("8 GJHX => 4 NSDBV");
//rules.Add("1 VFTG => 2 QNWD");
//rules.Add("2 JHSJ, 15 JNWJ, 1 ZMFXQ => 4 GVRK");
//rules.Add("1 PJFBD => 3 MZQLG");
//rules.Add("1 SJQL, 11 LPVWN => 9 DLZS");
//rules.Add("3 PRMJ, 2 XNWV => 6 JHSJ");
//rules.Add("4 SJQL => 8 PJFBD");
//rules.Add("14 QNWD => 6 STHQ");
//rules.Add("5 CNLFV, 2 VFTG => 9 XNWV");
//rules.Add("17 LWNKB, 6 KBWF, 3 PLSCB => 8 KZDJ");
//rules.Add("6 LHWZQ, 5 LWNKB => 3 ZDWX");
//rules.Add("5 RPLCK, 2 LPVWN => 8 ZMFXQ");
//rules.Add("1 QNWD, 2 TKRT => 3 CRPGK");
//rules.Add("1 JBPHS, 1 XNWV => 6 TLRST");
//rules.Add("21 ZDWX, 3 FZDP, 4 CRPGK => 6 PDTP");
//rules.Add("1 JCVP => 1 WXDVT");
//rules.Add("2 CRPGK => 9 FGVL");
//rules.Add("4 DQFL, 2 VNMV => 1 HGCR");
//rules.Add("2 GVRK, 2 VCFX, 3 PJFBD, 1 PLSCB, 23 FZDP, 22 PCSM, 1 JLVQ => 6 HFHL");
//rules.Add("1 CRPGK, 5 PJFBD, 4 XTCP => 8 PLSCB");
//rules.Add("1 HTZW, 17 FGVL => 3 LHWZQ");
//rules.Add("2 KBWF => 4 DQKLC");
//rules.Add("2 LHWZQ => 2 PRMJ");
//rules.Add("2 DLZS, 2 VCFX, 15 PDTP, 14 ZDWX, 35 NBZC, 20 JVMF, 1 BGWMS => 3 DWRH");
//rules.Add("2 TKVCX, 6 RPLCK, 2 HTZW => 4 XTCP");
//rules.Add("8 CNLFV, 1 NRSD, 1 VFTG => 9 VFZX");
//rules.Add("1 TLRST => 4 WDKW");
//rules.Add("9 VFCZG => 7 GJHX");
//rules.Add("4 FZDP => 8 JLVQ");
//rules.Add("2 ZMFXQ, 2 STHQ => 6 QDZB");
//rules.Add("2 SJQL, 8 ZDWX, 6 LPRL, 6 WXDVT, 1 TPRT, 1 JNWJ => 8 KLJMS");
//rules.Add("6 JBPHS, 2 ZBLC => 6 HTZW");
//rules.Add("1 PDTP, 2 LHWZQ => 8 JNWJ");
//rules.Add("8 ZBLC => 7 TKVCX");
//rules.Add("2 WDKW, 31 QDZB => 4 PCSM");
//rules.Add("15 GJHX, 5 TKVCX => 7 FZDP");
//rules.Add("15 SJQL, 3 PRMJ => 4 JCVP");
//rules.Add("31 CNLFV => 1 TGCW");
//rules.Add("1 TLRST, 2 WDKW => 9 KBWF");
//rules.Add("5 NRSD, 1 STHQ => 3 VFCZG");
//rules.Add("16 LPVWN, 13 KBWF => 2 BGWMS");
//rules.Add("5 BGWMS, 11 SJQL, 9 FZDP => 6 NBZC");
//rules.Add("175 ORE => 7 NRSD");
//rules.Add("5 HTZW => 4 LPVWN");
//rules.Add("4 PRMJ => 7 JVMF");
//rules.Add("6 PCSM, 8 DQKLC => 7 LPRL");
//rules.Add("2 CNLFV => 7 TKRT");
//rules.Add("3 FZDP => 3 LWNKB");
//rules.Add("1 HTZW => 4 RPLCK");
//rules.Add("180 ORE => 9 DQFL");
//rules.Add("102 ORE => 7 VNMV");
//rules.Add("103 ORE => 5 CNLFV");
//rules.Add("163 ORE => 2 VFTG");

rules.Add("10 OR => 10 A");
rules.Add("1 OR => 1 B");
rules.Add("7 A, 1 B => 1 C");
rules.Add("7 A, 1 C => 1 D");
rules.Add("7 A, 1 D => 1 E");
rules.Add("7 A, 1 E => 1 FUOL");

var remainders = new Dictionary<String, int>();
var tempL = new List<string>();

do
{
	tempL = new List<string>();
	foreach (var r in rules) //ingredient rule r
	{
		var rightSide1 = r.Split(new string[] { " => " }, StringSplitOptions.None)[1];
		var leftSide1 = r.Split(new string[] { " => " }, StringSplitOptions.None)[0];

		var leftSide1Split = Regex.Split(leftSide1, @"[,][ ]");

		foreach (var i in leftSide1Split) // ingredient i
		{
			var ingredient = i.Split(' ');


			foreach (var r2 in rules)
			{
				var rightSide2 = r2.Split(new string[] { " => " }, StringSplitOptions.None)[1];
				var leftSide2 = r2.Split(new string[] { " => " }, StringSplitOptions.None)[0];
				
				if (!(ingredient[1] == "OR"))
				{
					if (rightSide2.Contains(ingredient[1]))
					{
						if(!remainders.ContainsKey(ingredient[1]))
						{
							remainders.Add(ingredient[1], 0)
						}
						remainders[ingredient[1]] = 0;//the remainder
						var tempR = r;
						Regex regex = new Regex($"[0-9]+[ ]{ingredient[1]}");
						string cleanString = regex.Replace(tempR, r2.Split(new string[] { " => " }, StringSplitOptions.None)[0]);

						if (!rules.Any(s => s == cleanString) && !tempL.Any(s => s == cleanString))
						{
							tempL.Add(cleanString);
						}
					}
				}
			}
		}
	}
	rules = rules.Concat(tempL).ToList();
	//	rules.Dump();
} while (tempL.Count > 0);


rules.Dump();













































