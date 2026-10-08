using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BibliotecaScript : MonoBehaviour
{
    public LibroScript[] libros;
    public GameObject cartelReservado;

    // Start is called before the first frame update
    void Start()
    {
       libros = FindObjectsOfType <LibroScript> (); 
       for (int i = 0; i<libros.Length; i++)
       {
        libros[i].color = Random.Range (1,6);
       }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CheckIfReservedAndReserve (0);

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
CheckIfReservedAndReserve (1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CheckIfReservedAndReserve (2);

        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CheckIfReservedAndReserve (3);

        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            CheckIfReservedAndReserve (4);

        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            CheckIfReservedAndReserve (5);

        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            CheckIfReservedAndReserve (6);

        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            CheckIfReservedAndReserve (7);

        }
    }

    void MostrarMensajeReservado()
    {
        cartelReservado.SetActive(true);
        Invoke(nameof(OcultarMensajeReservado),2);
    }

    void OcultarMensajeReservado()
    {
        cartelReservado.SetActive(false);
    }

    void CheckIfReservedAndReserve (int index)
    {
        if (libros [index].reservado == false)
        {
            libros [index].color = 0;
            libros [index].reservado = true;
        }

        else 
        {
            MostrarMensajeReservado ();
        }
    }


}
