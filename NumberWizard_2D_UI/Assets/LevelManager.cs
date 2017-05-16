using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name) //name of the Level to load
    {
        Debug.Log("Level load requested for: " + name); //write to console
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("I wanna quit"); //write to console
        Application.Quit(); //has limitations, cannot coordinate with Web & Mobile O.S.
    }

}
