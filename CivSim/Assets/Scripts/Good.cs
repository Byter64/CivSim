using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Good
{
	public enum Type
	{
		None,
		Food,
	}
    
	public readonly Type type;
	public Good(Type type)
	{
		this.type = type;
	}
}
