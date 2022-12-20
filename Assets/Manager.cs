using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Manager : MonoBehaviour
{
    //IDetectation detectation;
    //private List<IDetectation> detectations = new List<IDetectation>();

    [SerializeField]
    SpawnController[] spawnController;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Type temp = detectation.GetType();
            //temp.GetMethod("DoWork").Invoke();
            for(int i = 0; i < spawnController.Length; i++)
            {
                spawnController[i].Spawn();
            }
            
            
        }
    }
}
