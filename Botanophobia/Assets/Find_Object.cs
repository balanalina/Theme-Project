using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Find_Object : MonoBehaviour
{
    private bool closeEnough = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k") && closeEnough == true)
        {
            SceneManager.LoadScene("Level1");
        }
    }
    
    void OnGUI()
    {
        if (Camera.main.transform.position.x >= -4 && Camera.main.transform.position.x <= 4 && Camera.main.transform.position.z >= -5 && Camera.main.transform.position.z <= 4)
        {
            Debug.Log("ok");
            GUI.Label(new Rect(10, 10, 200, 20), "[k]");
            closeEnough = true;
        }
    }
}
