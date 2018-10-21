using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public enum Location {Customer, Sink, CuttingBoard, Plate, Serve}

	private bool firstChoice;
	private Location myLocation;
	public GameObject recipe;
	public GameObject inventory;
	public GameObject recipeButton;
	public GameObject areaCuttingBoard;
	public GameObject areaSink;
	public GameObject areaMix;
	public GameObject areaPlate;

	// Use this for initialization
	void Start () {
		recipe.SetActive(true);
		inventory.SetActive(false);
		recipeButton.SetActive(false);
		firstChoice = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CheckFirstChoice () {
		if (firstChoice == false) 
		{
			recipeButton.SetActive(true);
			inventory.SetActive(true);
		}
	}

	public void SwitchToSink () 
	{
		CheckFirstChoice();
		recipe.SetActive(false);
		myLocation = Location.Sink;
		areaCuttingBoard.SetActive(true);
	}

	public void SwitchToRecipe ()
	{
		if (areaCuttingBoard.active == true)
		{
			areaCuttingBoard.SetActive(false);
		} else if (areaMix.active == true) 
		{
			areaMix.SetActive(false);
		} else if (areaPlate.active == true)
		{
			areaPlate.SetActive(false);
		} else if (areaSink.active == true)
		{
			areaSink.SetActive(true);
		} else if (areaPlate.active == true)
		{
			areaPlate.SetActive(true);
		};
		recipe.SetActive(true);

	}
}
