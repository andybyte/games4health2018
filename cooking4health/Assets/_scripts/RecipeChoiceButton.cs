﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecipeChoiceButton : MonoBehaviour {

	public string sceneToLoad;
	public void GoButton () 
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
