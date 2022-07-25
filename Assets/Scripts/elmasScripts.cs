using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elmasScripts : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "karakter")
        {
            Score.elmaspuani_int += 1;
            Destroy(this.gameObject);
        }
    }
}
