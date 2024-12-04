using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkChain
{
	public List<Work> chain;
	public int nextWork;

	//Goods that are created on completion of the work chain
	public Dictionary<Good.Type, int> resultingGoods;

	public WorkChain()
	{
		nextWork = 0;
		chain = new();
		resultingGoods = new();
	}

	public WorkChain AddWork(string name, float time, Dictionary<Good.Type, int> neededGoods)
	{
		chain.Add(new Work( name, time, this, neededGoods));
		return this;
	}

	public WorkChain SetResult(Dictionary<Good.Type, int> resultingGoods)
	{
		this.resultingGoods = resultingGoods;
		return this;
	}

	public float CalculateTimeLeft()
	{
		float timeLeft = 0;
		for (int i = nextWork; i < chain.Count; i++)
			timeLeft += chain[i].time;
		return timeLeft;
	}

	public Work this[int i]
	{
		get { return chain[i]; }
	}
}
