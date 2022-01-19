using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SliderController : MonoBehaviour
{
    int progress = 0;
    public Slider slider;
    int randomBottom;
    int randomTop;


    void Start()
    {

        // Makes the value increase fluently
        InvokeRepeating("UpdateProgress", 0.1f, 0.1f);

        // Defines buildIndex
        int buildIndex = SceneManager.GetActiveScene().buildIndex;

        // Indicates release area size of each stage (defines randomBottom, randomTop)
        if (buildIndex == 1)
        {
            randomBottom = Mathf.RoundToInt(Random.Range(0.0f, 0.8f) * 100);
            randomTop = randomBottom + 20;
        }

        else if (buildIndex == 2)
        {
            randomBottom = Mathf.RoundToInt(Random.Range(0.0f, 0.85f) * 100);
            randomTop = randomBottom + 15;
        }
        else if (buildIndex == 3)
        {
            randomBottom = Mathf.RoundToInt(Random.Range(0.0f, 0.9f) * 100);
            randomTop = randomBottom + 10;
        }

        else if (buildIndex == 4)
        {
            randomBottom = Mathf.RoundToInt(Random.Range(0.0f, 0.95f) * 100);
            randomTop = randomBottom + 5;
        }

        // Displays Values in Log
        Debug.Log(randomBottom);
        Debug.Log(randomTop);

    }


    public void UpdateProgress()

    {

        // Indicates speed, with which value increases
        // This can be adapted similarly to lines 25 to 46, if difficulty should be increased with more levels
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Value is happening");
            progress = progress + 2;
            slider.value = progress;
        }
        // Win and lose condition is based on this line. 
        else if (slider.value >= randomBottom && slider.value <= randomTop )  
        {
            
            Debug.Log(slider.value);
            

            int buildIndex = SceneManager.GetActiveScene().buildIndex;

            // This is the very last vicotry screen once the game was finished (after stage 4 for now)
            if (buildIndex == 4)
            {
                Debug.Log("Victory!");
                SceneManager.LoadScene("GameComplete");
            }

            // Appears when a level has been completed 
            else
            {
                Debug.Log("Stage completed!");
                PlayerPrefs.SetString("SceneIndex", buildIndex.ToString());
                SceneManager.LoadScene("StageComplete");
            }
        }

        // Appears when level has been lost
        else if (slider.value > 0)
        {
            Debug.Log("You've lost.");
            SceneManager.LoadScene("YouLost");
        }
    }



}
   
        
    



