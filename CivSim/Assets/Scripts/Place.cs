using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class Place : MonoBehaviour
{
	protected HashSet<WorkChain> workChains = new();

	/// <summary>
	/// 
	/// </summary>
	/// <returns>Returns a list of all currently doable works, which is sorted by their time in ascending order</returns>
	public List<WorkInfo> GetDoableWorks()
	{
		List<WorkInfo> works = new();
		foreach(WorkChain chain in workChains)
			works.Add(new WorkInfo(chain));

		return works.OrderBy(a => a.time).ToList();
	}
}
