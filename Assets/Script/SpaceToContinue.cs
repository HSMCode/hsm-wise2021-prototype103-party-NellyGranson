using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System; 

public class SpaceToContinue : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             int PrevSceneIndex = Int32.Parse(PlayerPrefs.GetString("SceneIndex"));
             SceneManager.LoadScene(PrevSceneIndex + 1);
        }
    }
}
