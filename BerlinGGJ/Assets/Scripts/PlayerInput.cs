﻿using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	private PlayerBase _playerBase;

	// Use this for initialization
	void Start () {
		_playerBase = GetComponent<PlayerBase> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
