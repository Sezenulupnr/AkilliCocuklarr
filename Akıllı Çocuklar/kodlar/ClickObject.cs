using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour {
    public Material green;
    public Material empty;
    private string objName;
    private GameObject obj;
    // Start is called before the first frame update

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (obj == null) {
                    empty = hit.transform.GetComponent<MeshRenderer>().material;
                    hit.transform.GetComponent<MeshRenderer>().material = green;
                    objName = hit.transform.name;
                    obj = GameObject.Find(objName);
                } else {
                    obj.transform.GetComponent<MeshRenderer>().material = empty;
                    objName = hit.transform.name;
                    obj = GameObject.Find(objName);
                    empty = hit.transform.GetComponent<MeshRenderer>().material;
                    hit.transform.GetComponent<MeshRenderer>().material = green;
                }



            }
        }
    }
}
