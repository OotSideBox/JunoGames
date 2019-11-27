using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrupteur : MonoBehaviour
{
    public GameObject mur;

    void OnCollisionEnter(Collision other)
    {
        //Si l'autre gameObject avec qui l'interrupteur entre en collision s'appelle "Kart"
        if (other.gameObject.name == "Kart")
        {
            //Détruire le gameObject du mur
            Debug.Log("Ouch !");
            Destroy(mur);
            Destroy(gameObject);
        }
    }
}