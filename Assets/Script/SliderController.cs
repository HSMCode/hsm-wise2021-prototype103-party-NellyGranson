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


    void Start()
    {
        randomBottom = Mathf.RoundToInt(Random.Range(0.0f, 0.9f) * 100);
        InvokeRepeating("UpdateProgress", 0.1f, 0.1f);
        Debug.Log(randomBottom);
    }


    public void UpdateProgress()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Value is happening");
            progress = progress + 1;
            slider.value = progress;
        }
        // this is important nelly pls dont forget this pls thanks
        else if (slider.value >= randomBottom && slider.value <= randomBottom + 20 )  
        {

            Debug.Log(slider.value);
            SceneManager.LoadScene("StageComplete");
        }
        else if (slider.value > 0)
        {
            Debug.Log("You've lost.");
            SceneManager.LoadScene("YouLost");
        }
    }

    
}
   
        
    



