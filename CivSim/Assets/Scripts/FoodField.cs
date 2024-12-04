using System.Collections.Generic;

public class FoodField : Place
{
	private void Awake()
	{
		WorkChain chain = new WorkChain();
		Dictionary<Good.Type, int> needed = new();
		Dictionary<Good.Type, int> rewards = new();
		needed[Good.Type.Food] = 1;
		rewards[Good.Type.Food] = 3;
		
		workChains.Add(chain.AddWork("Sow food", 1, needed).AddWork("Harvest food", 1, new()).SetResult(rewards));
	}

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
}