using UnityEngine;
using System.Collections;

public class Plant {
	//Static Variables and classes

	int life;
	int growth;

	const int MAXLIFE = 100;
	const int interval = 100;
	private int growthLevel;

	public Plant()
	{
		life = 100;
		growth = 1;
		growthLevel = 0;
	}

	public bool addWater(int water)
	{
		growthLevel += water;

		if (growthLevel >= interval) 
		{
			this.addGrowth();
			this.life = MAXLIFE;
			this.growthLevel = 0;
			return true;
		}
		return false;
	}

	public bool isDeath()
	{
		return life <= 0;
	}

	public int getLife()
	{
		return life;
	}

	public void addGrowth()
	{
		growth += 1;
	}
	public void addLife(int value)
	{
		life += value;
	}

	public void substractLife(int value)
	{
		life -= value;
	}


}
