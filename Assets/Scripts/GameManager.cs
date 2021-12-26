using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int puntos;
    public Text puntosJugador;
    public GameObject PantallaGanar;
    public GameObject PantallaPerder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ganar() 
    {
        Time.timeScale = 0;
        PantallaGanar.SetActive(true);
    }

    public void perder()
    {
        Time.timeScale = 0;
      PantallaPerder.SetActive(true);
    }

    public void sumapuntos() 
    {
        puntos = puntos + 15;
        puntosJugador.text = "Puntos: " + puntos;
    }

    public void irMenuNiveles() 
    {
        SceneManager.LoadScene("MenuNiveles");
    }
    
    public void irMenuPrincipal()
    {
        SceneManager.LoadScene("MenuInicio");
    }

    public void reinicioNivel()
    {
        SceneManager.LoadScene("Nivel1");
        Time.timeScale = 1;
    }

    public void nivel2()
    {
        SceneManager.LoadScene("Nivel2");
        Time.timeScale = 1;
    }

    public void nivel3()
    {
        SceneManager.LoadScene("Nivel3");
        Time.timeScale = 1;
    }
}

