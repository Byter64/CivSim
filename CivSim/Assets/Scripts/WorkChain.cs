using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkChain
{
	public List<Work> chain;
	public int nextWork;
	public float leftTime;
	public Dictionary<Good.Type, int> GetResultingGoods()
	{
		return chain[chain.Count - 1].resultingGoods;
	}

	public void UpdateLeftTime()
	{
		leftTime = 0;
		for (int i = nextWork; i < chain.Count; i++)
			leftTime += chain[i].time;

		foreach(Work work in chain)
			work.totalTimeLeft = leftTime;
	}
}
