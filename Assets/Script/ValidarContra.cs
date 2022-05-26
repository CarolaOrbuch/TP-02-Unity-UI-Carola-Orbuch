using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContra : MonoBehaviour
{
    string contraCorrecta;
    string contraUsr;
    public Text ingresoUsr;
    public Text textoMensaje;
    public GameObject popUpMensaje;
    // Start is called before the first frame update
    void Start()
    {
        contraCorrecta = "12345";
        popUpMensaje.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarContrasenia()
    {
        contraUsr = ingresoUsr.text;
        if (contraUsr == contraCorrecta)
        {
            popUpMensaje.SetActive(true);
            textoMensaje.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            popUpMensaje.SetActive(true);
            textoMensaje.text = "Contraseña Inconrrecta";
            Debug.Log("Contraseña Incorrecta");
        }
    }
}
