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
        InvokeRepeating("UpdateProgress", 0.1f, 0.1f);

        int buildIndex = SceneManager.GetActiveScene().buildIndex;

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
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Value is happening");
            progress = progress + 2;
            slider.value = progress;
        }
        // this is important nelly pls dont forget this pls thanks
        else if (slider.value >= randomBottom && slider.value <= randomTop )  
        {
            
            Debug.Log(slider.value);
            

            int buildIndex = SceneManager.GetActiveScene().buildIndex;

            if (buildIndex == 4)
            {
                SceneManager.LoadScene("GameComplete");
            }

            else
            {
                PlayerPrefs.SetString("SceneIndex", buildIndex.ToString());
                SceneManager.LoadScene("StageComplete");
            }
        }
        else if (slider.value > 0)
        {
            Debug.Log("You've lost.");
            SceneManager.LoadScene("YouLost");
        }
    }



}
   
        
    



