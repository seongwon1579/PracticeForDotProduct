using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;
using System.Linq;



public class SpawnController : MonoBehaviour
{
    //public Object[] enemy;
    public GameObject[] enemy;
    List<GameObject> enemySub = new List<GameObject>();

    [SerializeField]
    private Vector3 spawnPos;

    //private void Start()
    //{
    //    enemy = Resources.LoadAll("Prefab", typeof(GameObject));
    //    foreach (var temp in enemy)
    //    {
    //        enemySub.Add(temp as GameObject);
    //    }
    //}

    private void Start()
    {
        enemy = Resources.LoadAll("Prefab", typeof(GameObject)).Cast<GameObject>().ToArray();
        foreach(var temp in enemy)
        {
            enemySub.Add(temp);
        }
    }

    public void Spawn()
    {
        int randomIndex = Random.Range(0, enemy.Length - 1);
        Instantiate(enemy[randomIndex].gameObject, spawnPos, Quaternion.identity);
    }
}
