using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work
{
	public string name;
	public Dictionary<Good.Type, int> neededGoods;
	
	//Goods that are created directly on completion of the work
	public Dictionary<Good.Type, int> resultingGoods;

	//Goods that can be gained, by doing other works in a work chain
	public HashSet<WorkChain> memberOf;
	public float time;
}
