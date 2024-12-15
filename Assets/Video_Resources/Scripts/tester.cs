using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tester : MonoBehaviour
{

    public GameObject prefab;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void debuggerString(string input){
        Debug.Log(input);
    }


    public void SpawnPrefab()
    {
        Vector3 spawnPosition = transform.position + offset;
        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }
}
