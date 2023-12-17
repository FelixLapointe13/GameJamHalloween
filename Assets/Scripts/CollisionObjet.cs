using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObjet : MonoBehaviour
{
    public InfosJoueurs _joueur;

    public GameObject _potions;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip _onCollect;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Props") 
        {
            _joueur.nbPoints += 1;
            _potions.SetActive(false);
            audioSource.PlayOneShot(_onCollect);
        }
    }
}
