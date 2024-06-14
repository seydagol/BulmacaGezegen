using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket2 : MonoBehaviour
{
    Camera kamera;
    GameObject[] gölgeler;
    Vector2 baslangýc_posizyon;
    son son_script;

    void Start()
    {
        kamera = GameObject.Find("camera").GetComponent<Camera>();
        gölgeler = GameObject.FindGameObjectsWithTag("gölge");
        baslangýc_posizyon = transform.position;
        son_script = GameObject.Find("son").GetComponent<son>();

    }



    private void OnMouseDrag()
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }




    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject gölge in gölgeler)
            {
                if (gameObject.name == gölge.name)
                {
                    float mesafe = Vector3.Distance(gölge.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position = gölge.transform.position;
                        Destroy(this);
                        son_script.level_son();
                    }
                    else
                    {
                        transform.position = baslangýc_posizyon;
                    }
                }
            }
        }
    }



}
