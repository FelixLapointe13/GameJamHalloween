using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class AfficheDecompte : MonoBehaviour
{

    [SerializeField]
    private InfoNiveau _niveau;

    [SerializeField]
    private TMP_Text _textDecompte;

    public void AfficheTemps()
    {
        float temps = _niveau._timer;

        if (temps < 0)
        {
            temps = 0;
        }

        TimeSpan ts = TimeSpan.FromSeconds(temps);

        _textDecompte.text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
    }
}
