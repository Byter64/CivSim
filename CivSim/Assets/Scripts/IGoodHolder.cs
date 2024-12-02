using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGoodHolder : MonoBehaviour
{
	protected Dictionary<Good.Type, List<Good>> goods = new();

	public int Count(Good.Type type)
	{
		return goods[type].Count;
	}

	public void Create(Good.Type type, int amount = 1)
	{
		if (!goods.ContainsKey(type))
			goods[type] = new();
		
		for(;amount > 0; amount--)
			goods[type].Add(new Good(type));
	}

	public bool Remove(Good.Type type)
	{
		bool didRemove = goods[type] != null && goods[type].Count > 0;
		if (didRemove)
			goods[type].RemoveAt(goods[type].Count - 1);
		return didRemove;
	}
}
