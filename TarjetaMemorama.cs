using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarjetaMemorama : MonoBehaviour {
    public GameObject cartaAbajo;
    public EscenaControlador controlador;
    private int _id;
    public int id
    {
        get { return _id; }
      
    }

    public void SetTarjeta(int id, Sprite imagen)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = imagen;

    }


  
    public void OnMouseDown()
    {
        print("probando tarjeta");
        if (cartaAbajo.activeSelf)
        {
            cartaAbajo.SetActive(false);
        }
    }
}
