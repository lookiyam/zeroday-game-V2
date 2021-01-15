using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour {

public void selectScene(){
		switch (this.gameObject.name) {
		case "Tutorial":
			SceneManager.LoadScene ("Tutorial");
			break;
		case "Start":
			SceneManager.LoadScene ("Level1");
			break;
		case "Quit":
			SceneManager.LoadScene ("Scene03");
			break;
	}
}

}