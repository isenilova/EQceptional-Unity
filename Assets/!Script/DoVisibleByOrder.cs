using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoVisibleByOrder : MonoBehaviour
{
    public GameObject[] myList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoVis() {

       

        for (int i = 0; i < myList.Length; i++) myList[i].GetComponent<CanvasGroup>().alpha = 0;

        StartCoroutine(govislist());

       

    }


    IEnumerator govislist() {

        for (int i = 0; i < myList.Length; i++) {

            
            myList[i].GetComponent<DoVisible>().Dovisible();

            

            while (myList[i].GetComponent<CanvasGroup>().alpha < 1) yield return null;




        }




        yield return null;
    }

}
