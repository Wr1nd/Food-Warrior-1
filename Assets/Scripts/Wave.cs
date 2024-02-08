using System;
using System.Collections.Generic;
using OneLine;
using UnityEngine;

[Serializable]
public class SpawnItemData
{
	public float delay;
	public bool isBomb;
	public float x;
	public Vector2 velocity = new Vector2(0, 10f);

	public bool rV;
	public float xOffset;
	public float bombChance;
}

[Serializable]
public class Wave
{
	[OneLineWithHeader]public List<SpawnItemData> items;
}