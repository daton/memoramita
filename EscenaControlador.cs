using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscenaControlador : MonoBehaviour {
    public TarjetaMemorama tarjetaOriginal;
    [SerializeField] Sprite[] imagenes;
    int filas = 2;
    int columnas = 4;
    float dx = 2.5f;
    float dy = 2.5f;
   
	// Use this for initialization
	void Start () {


        Vector3 posInicial = tarjetaOriginal.transform.position;
        int[] numeros = { 0, 0, 1, 1, 2, 2, 3, 3 };
        numeros = BarajearArreglo(numeros);

        for (int i = 0; i < columnas; i++)
        {
            for (int j = 0; j < filas; j++)
            {
                TarjetaMemorama tarjeta;
                if (i == 0 && j == 0) tarjeta = tarjetaOriginal;
                else
                {
                    tarjeta = Instantiate(tarjetaOriginal) as TarjetaMemorama;
                }
                // int id = Random.Range(0, imagenes.Length);

                int indice = j * 4 + i;
                int id = numeros[indice];
                tarjeta.SetTarjeta(id, imagenes[id]);

                float posX = (dx * i) + posInicial.x;
                float posY = -(dy * j) + posInicial.y;
                tarjeta.transform.position = new Vector3(posX, posY, posInicial.z);
            }
        }
       
	}
    int[] BarajearArreglo(int[] numeros)
    {
        int[] arregloInterno = numeros.Clone() as int[];
        for(int i=0; i < arregloInterno.Length; i++)
        {
            int temporal = arregloInterno[i];
            int r = Random.Range(i, arregloInterno.Length);
            arregloInterno[i] = arregloInterno[r];
            arregloInterno[r] = temporal;
        }
        return arregloInterno;
    }

   
	// Update is called once per frame
	void Update () {
		
	}

 
}
