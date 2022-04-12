//Se debe ingresar la cantidad de entradas vendidas para cada tipo.
//Sabemos que el límite de espectadores totales en el predio del evento es de 20,400 personas en Campo 
//y 16,200 en Plateas y el precio de las entradas es de $1200 para Campo y $2000 para Platea.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ01 : MonoBehaviour
{
    public int campo;
    public int platea;
    int total;
    int platea1;
    int campo1;
    int vacante;
    void Start()
    {
        campo1 = campo * 1200;
        platea1 = platea * 2000;
        total = platea1 + campo1;
        vacante = platea1 + campo1 - total;
        if (campo < 0 || platea < 0 || campo > 16200 || platea > 20400)
        {
            Debug.Log("La cantidad es invalida");
        }

        else
        {
            Debug.Log("Lo total recaudado con el campo es " + campo1 + " Lo total recaudado con la platea es " + platea1 + " Lo total recaudado es " + total);
        }

        if (campo < 0 || platea < 0 || campo > 16200 || platea > 20400)
        {
            Debug.Log("La cantidad es invalida");
        }
        else if (total == 36600)
        {
            Debug.Log("Sold Out");
        }
        else if (campo1 + platea1 < 36600)
        {
            Debug.Log("Quedan " + vacante + "Entradas");
        }

        if (campo < 0 || platea < 0 || campo > 16200 || platea > 20400)
        {
            Debug.Log("La cantidad es invalida");
        }

        else if (campo > 8100 && platea > 10200)
        {
            Debug.Log("El festival fue un éxito!");
        }

        else if (campo < 8100 && platea < 10200)
        {
            Debug.Log("Debemos mejorar la convocatoria.");
        }

        else if (campo > 8100 && platea < 10200)
        {
            Debug.Log("Debemos mejorar la convocatoria.");
        }

        else if (campo < 8100 && platea > 10200)
        {
            Debug.Log("Debemos mejorar la convocatoria.");
        }
    }

}

    
    

