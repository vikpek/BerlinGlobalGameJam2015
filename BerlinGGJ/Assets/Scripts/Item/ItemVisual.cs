﻿using UnityEngine;
using System.Collections;

public class ItemVisual : MonoBehaviour {

	private ItemBase _itemBase;
	private PlayerInventory _playerInventory;
	[SerializeField] float spinningSpeed = 10.0f;
	private Animator anim;
	[SerializeField] float respawnTime = 10.0f;
	private float respawnTimer = 0;
	private bool visible = true;

	void Start()
	{
		_itemBase = GetComponent<ItemBase> ();
		_playerInventory = GameObject.FindGameObjectWithTag (Tags.PLAYER).GetComponent<PlayerInventory> ();
	}

	public void Update()
	{
		anim = GetComponent<Animator> ();
		if (!visible) 
		{
			respawnTimer += Time.deltaTime;
			if (respawnTimer >= respawnTime && !_playerInventory.ItemBaseList().Contains(_itemBase))
			{
				Appear();
			}
		}
	}

	public void Disappear()
	{
		SoundManager.sharedManager.Play (SoundManager.sharedManager.itemCollect, false, SoundManager.ENVIRONMENT);

		anim.SetTrigger("Disappear");
		respawnTimer = 0;
		visible = false;
		_itemBase.ItemController.Disable ();
	}

	public void Appear()
	{

		SoundManager.sharedManager.Play (SoundManager.sharedManager.itemDrop, false, SoundManager.ENVIRONMENT);
		
		_itemBase.ItemController.Enable ();
		anim.SetTrigger ("Appear");
		visible = true;
	}
}
