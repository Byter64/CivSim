using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work
{
	public string name;
	public float time;
	public WorkChain parentChain;

	public Dictionary<Good.Type, int> neededGoods;

	public Work(string name, float time, WorkChain parentChain, Dictionary<Good.Type, int> neededGoods)
	{
		this.name = name;
		this.time = time;
		this.parentChain = parentChain;
		this.neededGoods = neededGoods;
	}
}
