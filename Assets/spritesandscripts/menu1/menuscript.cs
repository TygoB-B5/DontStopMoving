using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public Collider coll;

    void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (coll.Raycast(ray, out hit, 10000.0f))
                {


                    SceneManager.LoadScene("level1");
                }
            }
        }
    }
                 
