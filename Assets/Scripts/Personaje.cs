using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Personaje : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ZonaVictoria")
        {   //aca ganas
            GameObject.FindObjectOfType<GameManager>().ganar();
        }
        if (collision.gameObject.tag == "ZonaDerrota")
        {
            //aca perde
            GameObject.FindObjectOfType<GameManager>().perder();

        }
    }
}


