using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishcollider4 : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Finish"))
        {
            TaskOnClick1();
        }
    }
    void TaskOnClick1()
    {
        Debug.Log("dead");
        SceneManager.LoadScene("Menu1");
    }
}