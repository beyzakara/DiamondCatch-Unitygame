using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text elmaspuani;
    public static int elmaspuani_int = 0;

    private void Update()
    {
        elmaspuani.text = elmaspuani_int.ToString();
    }



}
