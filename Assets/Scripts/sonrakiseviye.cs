using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sonrakiseviye : MonoBehaviour
{
    public void sonrakiseviyebutton()
    {
        SceneManager.LoadScene(3);
        Score.elmaspuani_int = 0;
    }
}
