using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // void si algo entra en el trigger, if verificar si es el player y sceneManager te manda al 2do nivel (scene)
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
            SceneManager.LoadScene (1);
    }
}
