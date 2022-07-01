using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gecisekrani : MonoBehaviour
{
  public void sahneyukle (string sahneadi)
    {
        Application.LoadLevel(sahneadi);
    }


    public void cikis()
    {
        Application.Quit();
    }






}


