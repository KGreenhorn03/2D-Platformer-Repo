using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    
    public string stage;

    public void Level()
    {

        SceneManager.LoadScene(stage);

    }

    public void Quit()
    {

        Application.Quit();

    }
}
