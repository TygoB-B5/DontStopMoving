using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathcol3 : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("dead"))
        {
            TaskOnClick1();
        }
    }
    void TaskOnClick1()
    {
        Debug.Log("dead");
        SceneManager.LoadScene("Level3");
    }
}