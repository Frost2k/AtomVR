﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

		public float dragSpeed = 2;
		private Vector3 dragOrigin;
		MoveMol controller;


		void LateUpdate()
		{
			if (Input.GetMouseButtonDown(1))
			{
				dragOrigin = Input.mousePosition;
				return;
			}


			if (!Input.GetMouseButton(1)) return;

			Vector3 pos = Camera.current.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
			Vector3 move = new Vector3(pos.x * dragSpeed, 0, pos.y * dragSpeed);

			transform.Translate(move, Space.World);  
		}
	 
}
