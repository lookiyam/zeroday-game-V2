using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour {

	
	public void backToMainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}