using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour {

    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public Text textomsg;
    public GameObject cartelmsg;

	// Use this for initialization
	void Start () {
        contraseniaCorrecta = "12345";
        cartelmsg.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ValidarContraseña()
    {
        contraseniaUsuario = ingresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            cartelmsg.SetActive(true);
            textomsg.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelmsg.SetActive(true);
            textomsg.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña Incorrecta");
        }
    }

}
