using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu_script : MonoBehaviour {

    Vector2 mousepos1, mousepos2, imagenpos, botonpos;
    public Animator imagenbarra;
    public Image imagen;
    public bool triggermouse, triggermouse2 , barrafuera;
    public Button sidebutton, shade;


	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
        //Aquí saca el sidebar
        if (barrafuera == false)
        { 
         if (Input.GetMouseButtonDown(0))
         {
            mousepos1 = Input.mousePosition;
            Debug.Log(mousepos1.x);
            if (mousepos1.x < 130)
            {
                Debug.Log("1");
                triggermouse = true;
            }
         }
        }
        if (triggermouse == true) {
            if (Input.GetMouseButtonUp(0))
            {
                mousepos2 = Input.mousePosition;
                Debug.Log(mousepos2.x);
                if (mousepos2.x > 130)
                {
                    Debug.Log("sliding");
                    imagenbarra.SetBool("slide out", false);
                    imagenbarra.SetBool("slide in", true);

                    barrafuera = true;
                    triggermouse = false;

                }
                else
                {
                    triggermouse = false;
                }
            }
        }
        // Aquí mete el sidebar
        if (barrafuera == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mousepos1 = Input.mousePosition;
                Debug.Log(mousepos1.x);
                if (mousepos1.x >160)
                {
                    Debug.Log("2");
                    triggermouse2 = true;
                }
            }
        }
        if (triggermouse2 == true)
        {
            if (Input.GetMouseButtonUp(0))
            {
                mousepos2 = Input.mousePosition;
                Debug.Log(mousepos2.x);
                if (mousepos2.x < 130)
                {
                    Debug.Log("sliding");
                    imagenbarra.SetBool("slide in", false);
                    imagenbarra.SetBool("slide out", true);

                    barrafuera = false;
                    triggermouse2 = false;

                }
                else
                {
                    triggermouse2 = false;
                }
            }
        }
    }

    //Este es el boton que Saca la barra 
    public void Sidebutton_fun ()
    {
        imagenbarra.SetBool("slide out", false);
        imagenbarra.SetBool("slide in", true);
        barrafuera = true;


    }
    //este es cuando presionas la sombra que aparece junto a la barra
    public void shade_fun()
    {
        imagenbarra.SetBool("slide in", false);
        imagenbarra.SetBool("slide out", true);
        barrafuera = false;
    }

}
