using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    public string stage;
    public void OnCollisionEnter2D(Collision2D collision)
    {

        SceneManager.LoadScene(stage);

    }

}
