using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Niveau : MonoBehaviour
{
    public InfosJoueurs _joueur;

    public InfoNiveau _Niveau;

    [SerializeField]
    private TMP_Text _textNombreDePoints;


    // Start is called before the first frame update
    void Start()
    {
        _joueur.nbPoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _textNombreDePoints.text = _joueur.nbPoints.ToString();
    }
}
