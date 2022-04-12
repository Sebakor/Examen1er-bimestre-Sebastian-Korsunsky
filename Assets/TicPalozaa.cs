using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicPalozaa : MonoBehaviour

{

    public int EntradasCampo = 20400;
    public int EntradasPlatea = 16200;


    int Total;

    int precioplatea;
    int preciocampo;
    int recaudaciontotal;

    int prediototal = 36200;

    int entradaslibres;



    

    void Start()
    {
        preciocampo = 1200 * EntradasCampo;

        Debug.Log(" La recaudacion de la entradas de campo fue de " + preciocampo);

        precioplatea = 2000 * EntradasPlatea;

        Debug.Log(" La recaudacion de la entradas de platea fue de " + precioplatea);


        recaudaciontotal = precioplatea + preciocampo;


        Debug.Log(" La recaudacion total fue de " + recaudaciontotal);


        prediototal = 20400 + 16200;
        

        entradaslibres = (EntradasCampo + EntradasPlatea) - prediototal;

        Debug.Log(" Vacantes disponibles " + entradaslibres);



    }

    // Update is called once per frame
    void Update()
    {


    }
}
    
