using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleStartButton : MonoBehaviour {

	public string sceneToLoad;

	public void TitleStart () 
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
