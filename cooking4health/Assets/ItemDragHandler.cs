using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public GameObject emptiedSlot;
    public static GameObject itemBeingDragged;


    public void OnBeginDrag(PointerEventData eventData)
    {
        
        itemBeingDragged = gameObject;
        Debug.Log("item being dragged!");
    }




    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.GetTouch(0).position;
        
    }



    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = Input.GetTouch(0).position;

    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
