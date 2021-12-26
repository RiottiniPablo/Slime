using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
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
            GameObject.FindObjectOfType<GameManager>().perder();
        }
        if (collision.gameObject.tag == "ZonaDerrota")
        {
            //aca perde
            GameObject.FindObjectOfType<GameManager>().sumapuntos();
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            GameObject.FindObjectOfType<GameManager>().perder();
        }
    }




















}
