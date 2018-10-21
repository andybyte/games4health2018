using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeButton : MonoBehaviour {

	public GameObject recipePanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EnableRecipe () {
		if (recipePanel != null) {
			if (recipePanel.active == false)
			{
				recipePanel.active = true;
			}
		}
	}
}
