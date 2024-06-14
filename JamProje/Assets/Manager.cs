using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject adam, karadelik, kedi, uzayli, gemi, ay, dunya, adamBlack, karadelikBlack, kediBlack, uzayliBlack, gemiBlack, ayBlack, dunyaBlack;

    Vector2 adamInitialPos, karadelikInitialPos, kediInitialPos, uzayliInitialPos, gemiInitialPos, ayInitialPos, dunyaInitialPos;

    void Start()
    {
        adamInitialPos = adam.transform.position;
        karadelikInitialPos = karadelik.transform.position;
        kediInitialPos = kedi.transform.position;
        uzayliInitialPos = uzayli.transform.position;
        gemiInitialPos = gemi.transform.position;
        ayInitialPos = ay.transform.position;
        dunyaInitialPos = dunya.transform.position;
    }

    public void DragAdam()
    {
        adam.transform.position = Input.mousePosition;
    }

    public void DragDunya()
    {
        dunya.transform.position = Input.mousePosition;
    }

    public void DragGemi()
    {
        gemi.transform.position = Input.mousePosition;
    }

    public void DragUzayli()
    {
        uzayli.transform.position = Input.mousePosition;
    }

    public void DragKedi()
    {
        kedi.transform.position = Input.mousePosition;
    }

    public void DragKaradelik()
    {
        karadelik.transform.position = Input.mousePosition;
    }

    public void DragAy()
    {
        ay.transform.position = Input.mousePosition;
    }


    public void DropAdam()
    {
        float Distance = Vector3.Distance(adam.transform.position, adamBlack.transform.position);
        if (Distance < 50)
        {
            adam.transform.position = adamBlack.transform.position;
        }
        else
        {
            adam.transform.position = adamInitialPos;
        }
    }

    public void DropKaradelik()
    {
        float Distance = Vector3.Distance(karadelik.transform.position, karadelikBlack.transform.position);
        if (Distance < 50)
        {
            karadelik.transform.position = karadelikBlack.transform.position;
        }
        else
        {
            karadelik.transform.position = karadelikInitialPos;
        }
    }


    public void DropAy()
    {
        float Distance = Vector3.Distance(ay.transform.position, ayBlack.transform.position);
        if (Distance < 50)
        {
            ay.transform.position = ayBlack.transform.position;
        }
        else
        {
            ay.transform.position = ayInitialPos;
        }
    }


    public void DropGemi()
    {
        float Distance = Vector3.Distance(gemi.transform.position, gemiBlack.transform.position);
        if (Distance < 50)
        {
            gemi.transform.position = gemiBlack.transform.position;
        }
        else
        {
            gemi.transform.position = gemiInitialPos;
        }
    }


    public void DropUzayli()
    {
        float Distance = Vector3.Distance(uzayli.transform.position, uzayliBlack.transform.position);
        if (Distance < 50)
        {
            uzayli.transform.position = uzayliBlack.transform.position;
        }
        else
        {
            uzayli.transform.position = adamInitialPos;
        }
    }

    public void DropDunya()
    {
        float Distance = Vector3.Distance(dunya.transform.position, dunyaBlack.transform.position);
        if (Distance < 50)
        {
            dunya.transform.position = dunyaBlack.transform.position;
        }
        else
        {
            dunya.transform.position = dunyaInitialPos;
        }

    }

    public void DropKedi()
    {
        float Distance = Vector3.Distance(kedi.transform.position, kediBlack.transform.position);
        if (Distance < 50)
        {
            kedi.transform.position = kediBlack.transform.position;
        }
        else
        {
            kedi.transform.position = kediInitialPos;
        }

    }
}