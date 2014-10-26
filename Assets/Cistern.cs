using UnityEngine;
using System.Collections;

public class Cistern {
	
	int limit;
	int level;

	public Cistern()
	{
		limit = 10;
		level = 0;
	}

	public bool isFull()
	{
		return level >= limit;
	}

	public bool isEmpty()
	{
		return level <= 0;
	}

	public void fill()
	{
		level = limit;
	}

	public void add(int value)
	{
		level += value;
	}
	public void substract(int value)
	{
		level -= value;
	}
	public int getLevel()
	{
		return this.level;
	}
	public int getLimit()
	{
		return this.limit;
	}


}
