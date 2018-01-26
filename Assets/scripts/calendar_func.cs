using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calendar_func : MonoBehaviour
{
    public Text mes_text, año_text, fecha_selec_text;
    string diasemana, diadelmes_string;
    int año, diasemanaint, diasemanaint2, Element, diamesint, mes_tipo, d, m, a, c, premax, mesmax, 
        cuartaparte, bisiesto, bisiesto2, Diadelmes,diazul, mupdate;
    public Button hoy_izquierda, hoy_derecha;
    public Dias[] dia;
    public Image Pendientes_del_dia;
    public Button Cerrar_pendiente;
    public bool slide_in, slide_out;


    // Use this for initialization
    void Start()
    {
        Diadelmes = System.DateTime.Now.Day;
        m = System.DateTime.Now.Month;
        mupdate = System.DateTime.Now.Month;
        año = System.DateTime.Now.Year;
        StartCoroutine("calcular_primer_dia", System.DateTime.Now.Year);
        mes_text.text = System.DateTime.Now.ToString("MM");
        diazul = System.DateTime.Now.Month;
        año_text.text = System.DateTime.Now.ToString("yyyy");
        año = System.DateTime.Now.Year;
        switch (mes_text.text)
        {
            case "01":
                premax = 31;
                mesmax = 31;
                mes_text.text = "Enero";
                break;
            case "02":
                premax = 31;
                mesmax = 28;
                mes_text.text = "Febrero";
                bisiesto = año % 400;
                if (bisiesto == 0)
                {
                    mesmax = 29;
                }
                else
                {
                    bisiesto = año % 4;
                    bisiesto2 = año % 100;
                    if (bisiesto == 0 && bisiesto2 != 0)
                    {
                        mesmax = 29;
                    }
                }
                break;
            case "03":
                premax = 28;
                mesmax = 31;
                mes_text.text = "Marzo";
                break;
            case "04":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Abril";
                break;
            case "05":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Mayo";
                break;
            case "06":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Junio";
                break;
            case "07":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Julio";
                break;
            case "08":
                premax = 31;
                mesmax = 31;
                mes_text.text = "Agosto";
                break;
            case "09":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Septiembre";
                break;
            case "10":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Octubre";
                break;
            case "11":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Noviembre";
                break;
            case "12":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Diciembre";
                break;
        }
        StartCoroutine("llenar_dias");
    }


    // Update is called once per frame
    void Update()
    {
        if(año == System.DateTime.Now.Year && mupdate == System.DateTime.Now.Month)
        {
         hoy_izquierda.gameObject.SetActive(false);
         hoy_derecha.gameObject.SetActive(false);
        }
        if (mupdate > System.DateTime.Now.Month)
        {
         hoy_derecha.gameObject.SetActive(false);
        }
        if (mupdate < System.DateTime.Now.Month)
        {
            hoy_izquierda.gameObject.SetActive(false);
        }
    }

    //Funciones de los botones
    public void Boton_derecha()
    {
        hoy_izquierda.gameObject.SetActive(true);
        mupdate = mupdate + 1;
        diazul = diazul + 1;
        switch (mes_text.text)
        {
            case "Enero":
                mes_text.text = "Febrero";
                premax = 31;
                mesmax = 28;
                m = 2;
                bisiesto = año % 400;
                if (bisiesto == 0)
                {
                    mesmax = 29;
                }
                else
                {
                    bisiesto = año % 4;
                    bisiesto2 = año % 100;
                    if (bisiesto == 0 && bisiesto2 != 0)
                    {
                        mesmax = 29;
                    }
                }
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Febrero":
                mes_text.text = "Marzo";
                premax = 28;
                mesmax = 31;
                m = 3;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Marzo":
                mes_text.text = "Abril";
                premax = 31;
                mesmax = 30;
                m = 4;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Abril":
                mes_text.text = "Mayo";
                premax = 30;
                mesmax = 31;
                m = 5;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Mayo":
                mes_text.text = "Junio";
                premax = 31;
                mesmax = 30;
                m = 6;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Junio":
                mes_text.text = "Julio";
                premax = 30;
                mesmax = 31;
                m = 7;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Julio":
                mes_text.text = "Agosto";
                premax = 31;
                mesmax = 31;
                m = 8;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Agosto":
                mes_text.text = "Septiembre";
                premax = 31;
                mesmax = 30;
                m = 9;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Septiembre":
                mes_text.text = "Octubre";
                premax = 30;
                mesmax = 31;
                m = 10;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Octubre":
                mes_text.text = "Noviembre";
                premax = 31;
                mesmax = 30;
                m = 11;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Noviembre":
                mes_text.text = "Diciembre";
                premax = 30;
                mesmax = 31;
                m = 12;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Diciembre":
                premax = 31;
                mesmax = 31;
                mes_text.text = "Enero";
                m = 1;
                if (año > System.DateTime.Now.Year)
                {
                    año = año + 1;
                    año_text.text = "" + año;
                }
                else
                {
                    año = año + 1;
                    año_text.text = "" + año;
                }
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
        }
    }
    public void Boton_Izquierda()
    {
        hoy_derecha.gameObject.SetActive(true);
        mupdate = mupdate - 1;
        diazul = diazul - 1;
        switch (mes_text.text)
        {
            case "Enero":
                mes_text.text = "Diciembre";
                premax = 31;
                mesmax = 31;
                m = 12;
                if (año < System.DateTime.Now.Year)
                {
                    año = año - 1;
                    año_text.text = "" + año;
                }
                else
                {
                    año = año - 1;
                    año_text.text = "" + año;
                }
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Febrero":
                mes_text.text = "Enero";
                premax = 31;
                mesmax = 31;
                m = 1;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Marzo":
                mes_text.text = "Febrero";
                premax = 31;
                mesmax = 28;
                m = 2;
                bisiesto = año % 400;
                if (bisiesto == 0)
                {
                    mesmax = 29;
                }
                else
                {
                    bisiesto = año % 4;
                    bisiesto2 = año % 100;
                    if (bisiesto == 0 && bisiesto2 != 0)
                    {
                        mesmax = 29;
                    }
                }
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Abril":
                mes_text.text = "Marzo";
                premax = 28;
                mesmax = 31;
                m = 3;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Mayo":
                mes_text.text = "Abril";
                premax = 31;
                mesmax = 30;
                m = 4;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Junio":
                mes_text.text = "Mayo";
                premax = 30;
                mesmax = 31;
                m = 5;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Julio":
                mes_text.text = "Junio";
                premax = 31;
                mesmax = 30;
                m = 6;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Agosto":
                mes_text.text = "Julio";
                premax = 30;
                mesmax = 31;
                m = 7;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Septiembre":
                mes_text.text = "Agosto";
                premax = 31;
                mesmax = 31;
                m = 8;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Octubre":
                mes_text.text = "Septiembre";
                premax = 31;
                mesmax = 30;
                m = 9;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Noviembre":
                mes_text.text = "Octubre";
                premax = 30;
                mesmax = 31;
                m = 10;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Diciembre":
                mes_text.text = "Noviembre";
                premax = 31;
                mesmax = 30;
                m = 11;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
        }
    }

    //botones "hoy"
    public void hoy_izquierda_fun ()
    {
        mupdate = System.DateTime.Now.Month;
        hoy_izquierda.gameObject.SetActive(false);
        StartCoroutine("llevar_a_hoy");
    }
    public void hoy_derecha_fun()
    {
        mupdate = System.DateTime.Now.Month;
        hoy_derecha.gameObject.SetActive(false);
        StartCoroutine("llevar_a_hoy");
    }

    public void llevar_a_hoy() { 
    Diadelmes = System.DateTime.Now.Day;
        m = System.DateTime.Now.Month;
        año = System.DateTime.Now.Year;
        StartCoroutine("calcular_primer_dia", System.DateTime.Now.Year);
    mes_text.text = System.DateTime.Now.ToString("MM");
        diazul = System.DateTime.Now.Month;
        año_text.text = System.DateTime.Now.ToString("yyyy");
        año = System.DateTime.Now.Year;
        switch (mes_text.text)
        {
            case "01":
                premax = 31;
                mesmax = 31;
                mes_text.text = "Enero";
                break;
            case "02":
                premax = 31;
                mesmax = 28;
                mes_text.text = "Febrero";
                bisiesto = año % 400;
                if (bisiesto == 0)
                {
                    mesmax = 29;
                }
                else
                {
                    bisiesto = año % 4;
                    bisiesto2 = año % 100;
                    if (bisiesto == 0 && bisiesto2 != 0)
                    {
                        mesmax = 29;
                    }
                }
                break;
            case "03":
                premax = 28;
                mesmax = 31;
                mes_text.text = "Marzo";
                break;
            case "04":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Abril";
                break;
            case "05":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Mayo";
                break;
            case "06":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Junio";
                break;
            case "07":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Julio";
                break;
            case "08":
                premax = 31;
                mesmax = 31;
                mes_text.text = "Agosto";
                break;
            case "09":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Septiembre";
                break;
            case "10":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Octubre";
                break;
            case "11":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Noviembre";
                break;
            case "12":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Diciembre";
                break;
        }
        StartCoroutine("llenar_dias");
    }

    //abrir-cerrar popup "pendientes"
    public void Boton_dia_pendientes_0()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[0].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_1()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[1].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;   
    }
    public void Boton_dia_pendientes_2()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[2].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_3()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[3].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;   
    }
    public void Boton_dia_pendientes_4()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[4].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_5()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[5].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_6()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[6].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_7()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[7].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_8()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[8].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_9()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[9].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_10()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[10].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_11()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[11].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_12()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[12].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_13()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[13].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_14()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[14].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_15()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[15].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_16()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[16].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_17()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[17].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_18()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[18].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_19()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[19].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_20()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[20].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_21()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[21].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_22()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[22].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_23()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[23].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_24()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[24].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_25()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[25].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_26()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[26].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_27()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[27].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_28()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[28].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_29()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[29].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_30()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[30].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_31()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[31].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_32()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[32].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_33()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[33].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_34()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[34].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }
    public void Boton_dia_pendientes_35()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
        fecha_selec_text.text = "Fecha seleccionada" + dia[35].día.GetComponentInChildren<Text>().text + "/" + mes_text.text + "/" + año_text.text;
    }

    public void Cierra_pendientes()
    {
        Pendientes_del_dia.gameObject.SetActive(false);
        Cerrar_pendiente.gameObject.SetActive(false);
    }

    //Llenar_botones
    //este void llenar dia utilizara las variables que llenara primeramente el void calculo
    void llenar_dias()
    {
        switch (diasemanaint)
        {
            case 0:
                diasemanaint = 6;
                break;
            case 1:
                diasemanaint = 0;
                break;
            case 2:
                diasemanaint = 1;
                break;
            case 3:
                diasemanaint = 2;
                break;
            case 4:
                diasemanaint = 3;
                break;
            case 5:
                diasemanaint= 4;
                break;
            case 6:
                diasemanaint = 5;
                break;  
        }

        switch (diasemanaint)
        {
            case 0:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (diamesint < mesmax)
                {
                    
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.white;
                    dia[Element].día.interactable = true;
                    if (año == System.DateTime.Now.Year && diazul == System.DateTime.Now.Month)
                    {
                        if (diamesint == System.DateTime.Now.Day)
                        {
                            dia[Element].día.image.color = Color.blue;
                        }
                    }
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                while (Element < 42)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
            case 1:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (diamesint < mesmax)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.white;
                    dia[Element].día.interactable = true;
                    if (año == System.DateTime.Now.Year && diazul == System.DateTime.Now.Month)
                    {
                        if (diamesint == System.DateTime.Now.Day)
                        {
                            dia[Element].día.image.color = Color.blue;
                        }
                    }
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                while (Element < 42)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
            case 2:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (diamesint < mesmax)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.white;
                    dia[Element].día.interactable = true;
                    if (año == System.DateTime.Now.Year && diazul == System.DateTime.Now.Month)
                    {
                        if (diamesint == System.DateTime.Now.Day)
                        {
                            dia[Element].día.image.color = Color.blue;
                        }
                    }
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                while (Element < 42)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
            case 3:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (diamesint < mesmax)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.white;
                    dia[Element].día.interactable = true;
                    if (año == System.DateTime.Now.Year && diazul == System.DateTime.Now.Month)
                    {
                        if (diamesint == System.DateTime.Now.Day)
                        {
                            dia[Element].día.image.color = Color.blue;
                        }
                    }
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                while (Element < 42)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
            case 4:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (diamesint < mesmax)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.white;
                    dia[Element].día.interactable = true;
                    if (año == System.DateTime.Now.Year && diazul == System.DateTime.Now.Month)
                    {
                        if (diamesint == System.DateTime.Now.Day)
                        {
                            dia[Element].día.image.color = Color.blue;
                        }
                    }
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                while (Element < 42)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
            case 5:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (diamesint < mesmax)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.white;
                    dia[Element].día.interactable = true;
                    if (año == System.DateTime.Now.Year && diazul == System.DateTime.Now.Month)
                    {
                        if (diamesint == System.DateTime.Now.Day)
                        {
                            dia[Element].día.image.color = Color.blue;
                        }
                    }
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                while (Element < 42)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
            case 6:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (diamesint < mesmax)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.white;
                    dia[Element].día.interactable = true;
                    if (año == System.DateTime.Now.Year && diazul == System.DateTime.Now.Month)
                    {
                        if (diamesint == System.DateTime.Now.Day)
                        {
                            dia[Element].día.image.color = Color.blue;
                        }
                    }
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                while (Element < 42)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    dia[Element].día.interactable = false;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
        }
    }
    //necesitamos 3 variables 
    //dia, año y mes
    //Dia = 1 (siempre)
    // A = El año - 2000
    //C = 6 (por ahora que sirva del 2000 pa lante)
    //Este void y los cases de los botones llenan las variables que utiliza la funcion que llena los dias,
    //Este void solo calcula que dia de la semana cae el primer dia de cada mes de cada año
    void calcular_primer_dia(int AA)
    {
        switch (m)
        {
            case 1:
                m = 1;

                bisiesto = AA % 400;
                if(bisiesto == 0)
                {
                    m = 0;
                }
                else
                { bisiesto = AA % 4;
                  bisiesto2 = AA % 100;
                    if(bisiesto == 0 && bisiesto2 != 0)
                    {
                        m = 0;
                    }
                }   
                break;
            case 2:
                m = 4;

                bisiesto = AA % 400;
                if (bisiesto == 0)
                {
                    m = 3;
                }
                else
                {
                    bisiesto = AA % 4;
                    bisiesto2 = AA % 100;
                    if (bisiesto == 0 && bisiesto2 != 0)
                    {
                     m = 3;
                    }
                }
                break;
            case 3:
                m = 4;
                break;
            case 4:
                m = 0;
                break;
            case 5:
                m = 2;
                break;
            case 6:
                m = 5;
                break;
            case 7:
                m = 0;
                break;
            case 8:
                m = 3;
                break;
            case 9:
                m = 6;
                break;
            case 10:
                m = 1;
                break;
            case 11:
                m = 4;
                break;
            case 12:
                m = 6;
                break;
        }
        d = 1;
        c = 6;
        a = AA - 2000;
        cuartaparte = a / 4;
        diasemanaint = (c + a + cuartaparte +  d + m) % 7;
        Debug.Log("diasemanaint" + diasemanaint);
        Debug.Log("a" + a);
        Debug.Log("D" + d);
        Debug.Log("M" + m);
        Debug.Log("C" + c);

    }
}

[System.Serializable]
public class Dias
{
    public Button día;
}
