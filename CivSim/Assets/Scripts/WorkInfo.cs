using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct WorkInfo
{
	public string name;
	public float time;
	public HashSet<Work> work;

	public Dictionary<Good.Type, int> neededGoods;

	//Goods that are created on completion of the work or work chain
	public Dictionary<Good.Type, int> resultingGoods;
}