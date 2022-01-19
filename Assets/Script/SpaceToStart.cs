using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceToStart : MonoBehaviour
{
    // Script lies on TitleScene. It will load the first level upon pressing space.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("LevelOne");
        }
    }
}
