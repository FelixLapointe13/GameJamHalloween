using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Decompte : MonoBehaviour
{
    [SerializeField]
    private InfoNiveau _niveau;

    private bool _decompteActif = false;

    public UnityEvent _changementDuTemps;
    public UnityEvent _finDuTemps;

    // Start is called before the first frame update
    void Start()
    {
        DemarrerDecompte();
    }

    // Update is called once per frame
    void Update()
    {
        if (_decompteActif) { 
            
            if (_niveau._timer > 0) 
            {
                _niveau._timer -= Time.deltaTime;
                _changementDuTemps.Invoke();
            }
            else 
            {
                _niveau._timer = 0;
                _decompteActif = false;
                _finDuTemps.Invoke();
            }
        }
    }

    public void DemarrerDecompte() 
    {
        _niveau._timer = _niveau._timerStart;
        _decompteActif = true;
    }
}
