using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerDemo : MonoBehaviour {
    
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

	}
}
