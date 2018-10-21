using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public enum Location {Customer, Sink, CuttingBoard, Mix, Plate, Serve}

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
		areaSink.SetActive(true);
	}

	public void SwitchToCuttingBoard () 
	{
		CheckFirstChoice();
		recipe.SetActive(false);
		myLocation = Location.CuttingBoard;
		areaCuttingBoard.SetActive(true);
	}

	public void SwitchToMix () 
	{
		CheckFirstChoice();
		recipe.SetActive(false);
		myLocation = Location.Mix;
		areaMix.SetActive(true);
	}

	public void SwitchToPlate () 
	{
		CheckFirstChoice();
		recipe.SetActive(false);
		myLocation = Location.Plate;
		areaPlate.SetActive(true);
	}

	public void SwitchToServe () 
	{
		SceneManager.LoadScene("ilia_scene5");
	}

	public void SwitchToRecipe ()
	{
		if (areaCuttingBoard.active == true)
		{
			areaCuttingBoard.SetActive(false);
		} 
		if (areaMix.active == true) 
		{
			areaMix.SetActive(false);
		} 
		if (areaPlate.active == true)
		{
			areaPlate.SetActive(false);
		} 
		if (areaSink.active == true)
		{
			areaSink.SetActive(false);
		} 
		if (areaPlate.active == true)
		{
			areaPlate.SetActive(false);
		};
		recipe.SetActive(true);

	}
}
