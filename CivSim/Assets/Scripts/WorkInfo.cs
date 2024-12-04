using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct WorkInfo
{
	public string name;
	public float time;
	public Work work;

	public Dictionary<Good.Type, int> neededGoods;

	//Goods that are created on completion of the work chain. If this work is not the last one in the chain, the resulting goods will not be received yet
	public Dictionary<Good.Type, int> resultingGoods;

	public WorkInfo(WorkChain chain)
	{
		work = chain[chain.nextWork];
		name = work.name;
		time = chain.CalculateTimeLeft();
		neededGoods = work.neededGoods;
		resultingGoods = chain.resultingGoods;
	}
}