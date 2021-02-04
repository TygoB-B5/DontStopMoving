using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectscript : MonoBehaviour
{
    public Collider coll2;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (coll2.Raycast(ray, out hit, 10000.0f))
            {


                SceneManager.LoadScene("Select1");
            }
        }
    }
}

