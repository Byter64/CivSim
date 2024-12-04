using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Good
{
	public enum Type
	{
		None,
		Food,
		BuildingMaterial1,
		BuildingMaterial2,
		BuildingMaterial3,
	}
    
	public readonly Type type;
	public Good(Type type)
	{
		this.type = type;
	}
}
