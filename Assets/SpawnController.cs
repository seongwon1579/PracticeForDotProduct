using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public Detectation[] enemy;

    [SerializeField]
    private Vector3 spawnPos;

    private void Start()
    {

        //enemy = Resources.Load<>;

    }

    public void Spawn()
    {
        int randomIndex = Random.Range(0, enemy.Length-1);
        
        Instantiate(enemy[randomIndex].gameObject, spawnPos, Quaternion.identity);
    }
}
