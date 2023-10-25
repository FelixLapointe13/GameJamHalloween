using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "InfoNiveau", menuName = "SO/Niveau")]
public class InfoNiveau : ScriptableObject
{
    [Header ("Temps du jeu")]
    public float _timer;
    public float _timerStart;

    private void OnEnable()
    {
        _timerStart = 300f;
    }
}
