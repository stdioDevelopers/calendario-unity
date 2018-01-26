using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour {
    int pregistradas;
    public Canvas canvasinicio, canvasregist;
    public InputField correor, contraseñar, correoi, contraseñai;
    string correo, contraseña;

	// Use this for initialization
	void Start () {
        pregistradas = 4;
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    //Botón para iniciar sesión
    public void iniciarSesion ()
    {
        
        if (correoi.text == correo && contraseñai.text == contraseña )
        {
            Debug.Log("fino");
        }
    }
    //Botón que lleva a la sección de registro
    public void registrarse()
    {
        canvasinicio.gameObject.SetActive(false);
        canvasregist.gameObject.SetActive(true);
    }
    //Botón para guardar el registro
    public void registrobt()
    {
        if(correor.text != "" | contraseñar.text != "") {
            correo = correor.text;
            contraseña = contraseñar.text;
            canvasinicio.gameObject.SetActive(true);
        canvasregist.gameObject.SetActive(false);
       }
    }
}
