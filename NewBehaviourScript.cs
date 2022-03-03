using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void LoadScene(){
        SceneManager.LoadScene("MainScene")
    }

    public void ExitApplication(){

        Application.Quit();
        Debug.Log("Project is closed")
    }

    public void LoadMenuScene(){
        SceneManager.LoadScene("MainMenu")
    }
    
}
