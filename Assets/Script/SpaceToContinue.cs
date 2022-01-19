using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System; 

public class SpaceToContinue : MonoBehaviour
{
    // Code defines by USE OF BUILD INDEX NUMBERS which stage to load next.
    // It is therefore urgendly necessairy to regard the buildIndex when adding new levels to the build settings.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             int PrevSceneIndex = Int32.Parse(PlayerPrefs.GetString("SceneIndex"));
             SceneManager.LoadScene(PrevSceneIndex + 1);
        }
    }
}
