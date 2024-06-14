using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class son : MonoBehaviour
{

    int toplamhayvan = 2;
    int ilk_hayvan = 0;

  
    public void level_son ()
    {
        ilk_hayvan++;

        if(ilk_hayvan == toplamhayvan)
        {
            Debug.Log("OYUN BÝTTÝ");
        }
    }

 
  
}
