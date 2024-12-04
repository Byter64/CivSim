using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class Place : MonoBehaviour
{
	private HashSet<WorkChain> workChains;

	/// <summary>
	/// 
	/// </summary>
	/// <returns>Returns a list of all currently doable works, which is sorted by totalTimeLeft in ascending order</returns>
	public List<Work> GetDoableWorks()
	{

		foreach(WorkChain chain in workChains)
			chain.UpdateLeftTime();

		IOrderedEnumerable<Work> result = workChains.Select(chain => { return chain.chain[chain.nextWork]; })
			.OrderBy(a => a.totalTimeLeft);
		return result.ToList();
	}
}
