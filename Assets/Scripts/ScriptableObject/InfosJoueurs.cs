using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfosJoueur", menuName = "SO/NouveauJoueur")]
public class InfosJoueurs : ScriptableObject
{
    [Header("Points du joueur")]
    public int nbPoints;
    
    private void OnEnable()
    {
        nbPoints = 0;
    }
}
