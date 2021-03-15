using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaAleatoria : MonoBehaviour
{
    int index_1;
    int index_2;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Carrega na tecla espaço e eu vou dar-te uma carta aleatória!");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {

            var list_1 = new List<string> { "ÁS", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valete", "Dama", "Rei" };
            var list_2 = new List<string> { "Espadas", "Paus", "Ouros", "Copas" };

            index_1 = Random.Range(1, list_1.Count);
            index_2 = Random.Range(1, list_2.Count);

            Debug.Log("A carta que saiu foi: " + list_1[index_1] + " de " + list_2[index_2]);

            Debug.Log("Para nova carta, carrega no espaço!");

        }
    }
}
