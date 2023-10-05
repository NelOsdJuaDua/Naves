using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject globoPrefab; //Que va spawnear
    public GameObject[] globos;
    public int spawnCount = 10; //cuantos
    public float spawnOffset; //Limites establecer la region
                              // Start is called before the first frame update
    void Start()
    {
        if (globoPrefab != null)
        {
            //Spawn
            SpawnGlobos();
        }
        else
        {
#if UNITY_EDITOR
Debug.LogError("No tiene globos asignados");
#endif
        }
    }
    void SpawnGlobos()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            //Posicion
            float xPosition = i * spawnOffset;
            Vector3 spawnPosition = new Vector3(xPosition, 0f, 0f);
            //instanciar
            //Instantiate(globoPrefab,spawnPosition, Quaternion.identity); Solo un prefab
            Instantiate(globos[GetRandomGlobo()], spawnPosition, Quaternion.identity);//Array
        }
    }
    int GetRandomGlobo()
    {
        int randomglobo = Random.Range(1, globos.Length);
        return randomglobo;
    }
}
