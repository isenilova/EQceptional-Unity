using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActDisObj : MonoBehaviour
{
    public GameObject[] actobj;
    public GameObject[] disobj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void goActDis() {

        for (int i = 0; i < actobj.Length; i++) actobj[i].SetActive(true);
        for (int i = 0; i <disobj.Length; i++) disobj[i].SetActive(false);



    }
}
