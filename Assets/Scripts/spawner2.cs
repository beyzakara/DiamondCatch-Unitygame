using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawner2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "karakter")
        {
            SceneManager.LoadScene(2);
            Score.elmaspuani_int = 0;
        }
    }

}
