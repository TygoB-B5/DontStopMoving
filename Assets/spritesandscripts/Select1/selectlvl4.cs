using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectlvl4 : MonoBehaviour
{
    public Collider coll6;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (coll6.Raycast(ray, out hit, 10000.0f))
            {


                SceneManager.LoadScene("Level4");
            }
        }
    }
}

