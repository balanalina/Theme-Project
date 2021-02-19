using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Time_Limit : MonoBehaviour
{
    public float delay;
    public string NewLevel;
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        if (delay > 0)
        {
            delay -= Time.deltaTime;
        }
        else
        {
            Debug.Log("intra");
            SceneManager.LoadScene(NewLevel);
        }
    }
}
