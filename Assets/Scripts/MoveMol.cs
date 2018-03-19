﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveMol : MonoBehaviour {

	private Vector3 screenPoint;
	private Vector3 offset;

	void LateUpdate()
	{
		if (Input.GetMouseButtonDown(0))
		{
			OnMouseDown();
			return;
		}
		if (!Input.GetMouseButtonDown(0))
		{
			OnMouseDrag();
			return;
		}
	}
	void OnMouseDown()
	{
		screenPoint = Camera.current.WorldToScreenPoint (gameObject.transform.position);

		offset = gameObject.transform.position - Camera.current.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		
	}
	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.current.ScreenToWorldPoint (curScreenPoint)+ offset;
		transform.position = curPosition;
	}
}
	 
	 