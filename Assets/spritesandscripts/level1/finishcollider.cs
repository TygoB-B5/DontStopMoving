﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishcollider : MonoBehaviour {

        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.CompareTag("Finish"))
            {
                TaskOnClick2();
            }
        }
        void TaskOnClick2()
        {
            Debug.Log("Finish");
            SceneManager.LoadScene("level2");
        }
    }
