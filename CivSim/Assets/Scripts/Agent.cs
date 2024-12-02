using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : IGoodHolder
{
	private Dictionary<Func<IEnumerator>, Func<int>> actions = new();
	private List<(Func<IEnumerator> action, int priority)> priorities = new();
#if UNITY_EDITOR
	[SerializeField]
	private List<string> actionNames = new();
	[SerializeField]
	private List<int> actionPriorities = new();
#endif

	void Awake()
	{
		actions = new Dictionary<Func<IEnumerator>, Func<int>>
		{
			{GetFood, FoodRule},
			{Chilling, ChillRule},
		};

		foreach (Func<IEnumerator> action in actions.Keys)
		{
			priorities.Add((action, 0));
#if UNITY_EDITOR
			actionNames.Add("");
			actionPriorities.Add(0);
#endif			
		}
		Create(Good.Type.Food, 100);
	}

	// Start is called before the first frame update
	void Start()
    {
		StartCoroutine(UpdateAction(5));
		StartCoroutine(Eating(1));
    }

	private IEnumerator Eating(float delta)
	{
		while (true)
		{
			yield return new WaitForSeconds(delta);
			bool enoughToEat = Remove(Good.Type.Food);
			if (!enoughToEat) { Destroy(gameObject); }
		}
	}

	private IEnumerator UpdateAction(float updateFrequency)
	{
		while (true)
		{
			for (int i = 0; i < priorities.Count; i++)
			{
				var tuple = priorities[i];
				Func<IEnumerator> action = tuple.action;
				tuple.priority = actions[action].Invoke();
				priorities[i] = tuple;
			}
			priorities.Sort((a, b) => { return b.priority - a.priority; });

#if UNITY_EDITOR
			for (int i = 0; i < priorities.Count; i++)
			{
				actionNames[i] = priorities[i].action.Method.Name;
				actionPriorities[i] = priorities[i].priority;
			}
#endif

			yield return new WaitForSeconds(updateFrequency);
		}
	}

	private int FoodRule()
	{
		return 100 - Count(Good.Type.Food);
	}

	private IEnumerator GetFood()
	{
		yield return null;
	}

	private int ChillRule()
	{
		return 5;
	}

	private IEnumerator Chilling()
	{
		yield return null;
	}
}
