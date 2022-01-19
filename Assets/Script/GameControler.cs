using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    // Spawns lady and mug
    // Is not a randomised script. You have to add textures manually in Unity.
    public GameObject lady;
    public GameObject mug;
    public Transform spawnPointLady;
    public Transform spawnPointMug;

    private void Start()
    {
        Spawnlady();
        SpawnMug();
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
