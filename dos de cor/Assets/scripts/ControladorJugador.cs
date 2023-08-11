using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float fuerzaSalto = 5;
    private Rigidbody2D miCuerpo; //Referencia al componente gigibody2dxd
    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>(); //Obtengo el componente y lo guardo en la variable
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            print("Se presion+o salto");
            miCuerpo.AddForce(
                new Vector3(
                    0,//x
                      fuerzaSalto, //y
                      0), ForceMode2D.Impulse);
        }
            //Si en este frame fue presionado el botón para saltar, el espacio.

    }
}
