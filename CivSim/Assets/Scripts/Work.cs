using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work
{
	public string name;
	public float time;
	public HashSet<WorkChain> memberOf;

	public Dictionary<Good.Type, int> neededGoods;
}
