// Based on Holistic 3D https://youtu.be/w8VxeZa-_fI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour {

	GameObject obj = null;
	Plane objPlane;
	Vector3 mO;

	Ray GenerateMouseRay ()
	{
		Vector3 mousePosVar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
		Vector3 mousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
		Vector3 mousePosF = Camera.main.ScreenToWorldPoint(mousePosVar);
		Vector3 mousePosN = Camera.main.ScreenToWorldPoint(mousePosNear);

		Ray mr = new Ray(mousePosN, mousePosF-mousePosN);
		return mr;
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			Ray mouseRay = GenerateMouseRay();
			RaycastHit hit;

			if (Physics.Raycast(mouseRay.origin, mouseRay.direction, out hit))
			{
				obj = hit.transform.gameObject;
				objPlane = new Plane(Camera.main.transform.forward*-1, obj.transform.position);

				// Calculate mouse offset
				Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
				float rayDistance;
				if (objPlane.Raycast(mRay, out rayDistance))
				{
					obj.transform.position = mRay.GetPoint(rayDistance) + mO;
				}
				else if (Input.GetMouseButtonUp(0) && obj)
				{
					obj = null;
				}
			}
		}
	}
}
