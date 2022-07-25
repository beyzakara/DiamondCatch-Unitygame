using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sonrakiseviyescripts : MonoBehaviour
{
  public void sonrakiseviyebutton()
    {
        SceneManager.LoadScene(2);
        Score.elmaspuani_int = 0;
    }
}
