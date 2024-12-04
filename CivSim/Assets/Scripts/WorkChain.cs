using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkChain
{
	public List<Work> chain;
	public int nextWork;
	public float leftTime;

	//Goods that are created on completion of the work chain
	public Dictionary<Good.Type, int> resultingGoods;


	public void UpdateLeftTime()
	{
		leftTime = 0;
		for (int i = nextWork; i < chain.Count; i++)
			leftTime += chain[i].time;

		foreach(Work work in chain)
			work.totalTimeLeft = leftTime;
	}
}
