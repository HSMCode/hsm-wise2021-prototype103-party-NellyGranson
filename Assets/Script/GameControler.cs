using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{

    public GameObject lady;
    public GameObject mug;
    public Transform spawnPointLady;
    public Transform spawnPointMug;

    // Start is called before the first frame update
    void Start()
    {
        Spawnlady();
        SpawnMug();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawnlady()
    {
        Instantiate(lady, spawnPointLady.position, Quaternion.identity);
    }

    void SpawnMug()
    {
        Instantiate(mug, spawnPointMug.position, Quaternion.identity);
    }
}
