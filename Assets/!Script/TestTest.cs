using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DoDelete() {


        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene("Main");


    }

    public void GoScene() {


        SceneManager.LoadScene("Main");

    }

}
