using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPosition : MonoBehaviour
{


   public GameObject obj;
    private GameObject obj2;
   public GameObject Panel;
   public GameObject FinishPanel;
    public Vector3 lastPos;
    public static bool Restart=false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Finish")
        {
    FinishPanel.SetActive(true);
          Debug.Log("Bitti");
        } 
        else if (collision.gameObject.tag=="GameOver")
        {
            Application.LoadLevel(4);
            Restart=true;
          Debug.Log("Kaybettin");
        }
    }
    // void Awake(){
    // if(Restart==true){
    //         Pause.Instance.Levels[0].SetActive(false);
    //         Pause.Instance.Levels[Pause.Instance.Level].SetActive(false);
    //         Restart=false;
    //         }
    // }
    
    void Update() {

        if (Input.GetMouseButton(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
             obj2=hit.transform.gameObject;
                if (obj == obj2) {
                    Vector3 pos = Input.mousePosition;
                    pos.z = 37;
                    lastPos = Camera.main.ScreenToWorldPoint(pos);
                    transform.position = lastPos;
                }
            }
        }
    }
}