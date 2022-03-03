using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class randomdmm : MonoBehaviour
{
// Start is called before the first frame update
    public void LoadScene()
    {
        SceneManager.LoadScene("MainScene");

    }

// Update is called once per frame
    public void ExitApplication()
    {
        Application.Quit();
        Debug.Log("Project is closed");
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
