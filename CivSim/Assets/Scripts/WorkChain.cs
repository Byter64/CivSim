using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkChain
{
	public List<Work> chain;

	public Dictionary<Good.Type, int> GetResultingGoods()
	{
		return chain[chain.Count - 1].resultingGoods;
	}
}
