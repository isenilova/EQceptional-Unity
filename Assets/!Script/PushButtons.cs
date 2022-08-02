using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushButtons : MonoBehaviour
{
    public GameObject[] myBut;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GoPush() {

        for (int i = 0; i < myBut.Length; i++)

            myBut[i].GetComponent<Button>().onClick.Invoke();



    }
}
