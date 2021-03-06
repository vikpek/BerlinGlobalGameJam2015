﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemProperty : MonoBehaviour {

	[SerializeField] private Texture slotImage;
	[SerializeField] private int itemId = 0;
	[SerializeField] private int posessionCount = 0;
	[SerializeField] private int initialUses = 2;

	public int WeaponType { get; set; }
	public int ItemId { get{return itemId;} }

	void Start()
	{
		posessionCount = initialUses;
	}

	public void DecreasePosessionCount()
	{
		if (posessionCount > 0) 
		{
			posessionCount--;
		}
	}

	public void ResetPosessionCount()
	{
		posessionCount = initialUses;
	}

	public bool CanUseItem()
	{
		return (posessionCount > 0);
	}

	public Texture SlotImage()
	{
		return slotImage;
	}

//	public Sprite SpriteImage()
//	{
//		return transform.
//	}
}
