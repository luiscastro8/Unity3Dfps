﻿using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour
{

	public GameObject player;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y + 3, transform.position.z);	
	}
}
