using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //typ_zmiennej nazwa;
        //deklaracja
        int a;
        //inicjalizacja
        a = 10;
        //2 w 1
        int b = 20;

        { //skakanie

            Debug.Log(b);
        }

        { //chodzenie

            int c = 20;
        }
        //Debug.Log(c);

        float fa = 1.5f;
        fa = 20.0f;
        bool logiczna = true; //false
        string str = "napis";

        Debug.Log(" fa: " + fa + " logiczna: " + logiczna +" str: " +str);

        //operacje na zmiennych + - * /
        Debug.Log(a / b);
        Debug.Log(a / fa);
        Debug.Log(Mathf.Sqrt(2));

        //operacje logiczne
        Debug.Log(a == b);
        Debug.Log(a != b);
        Debug.Log(a > b);
        Debug.Log(a >= b);
        Debug.Log(a < b);
        Debug.Log(a <= b);

        //if(warunek_logiczny)
        //{

        //}

        if(a == b)
        {
            Debug.Log("Tak, jest różna!");
        } else if (a > b)
        {
            Debug.Log("a > b");
        } else
        {
            Debug.Log("Żadne z powyższych");
        }

        Debug.Log((a != b) && (a > 0));

      

        //brzydka wersja
        int hp = 2, time = 1;
        bool amulet = true;

        if (hp <= 0)
        {
            if (amulet)
            {
                //sprawdzamy czy amulet == true
            }
            else
            {

            }
        }
        if (time <= 0)
        {
            if (amulet) 
            {  
                //sprawdzamy czy amulet == true
            }else
            {

            }
        }
            
        //ladna wersja
        if(hp <=0 || time <= 0)
        {
            if (amulet)
            {
                //sprawdzamy czy amulet == true
            }
            else
            {

            }
        }
    }

    public void Koniunkcja(int a, int b)
    {
        if (a != b)
        {
            if (a > 0)
            {
                //kod
            }
        }

        if ((a != b) && (a > 0))
        {
            //kod
        }
    }

    public void Alternatywa()
    {
        //brzydka wersja
        int hp = 2, time = 1;
        bool amulet = true;

        if (hp <= 0)
        {
            if (amulet)
            {
                //sprawdzamy czy amulet == true
            }
            else
            {

            }
        }
        if (time <= 0)
        {
            if (amulet)
            {
                //sprawdzamy czy amulet == true
            }
            else
            {

            }
        }

        //ladna wersja
        if (hp <= 0 || time <= 0)
        {
            if (amulet)
            {
                //sprawdzamy czy amulet == true
            }
            else
            {

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
