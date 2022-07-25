using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OYNASCRİPT : MonoBehaviour
{
    public void sonrakiseviyebutton()
    {
        SceneManager.LoadScene(1);
        Score.elmaspuani_int = 0;
    }
}
