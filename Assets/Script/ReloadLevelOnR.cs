using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReloadLevelOnR : MonoBehaviour
{

    // Defines a game reset. This is primarily a bug fix.
    // It will always reset to LevelOne rather than resetting an active Scene. 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("LevelOne");
        }
    }
}
