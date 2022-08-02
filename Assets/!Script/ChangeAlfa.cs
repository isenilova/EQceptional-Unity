using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAlfa : MonoBehaviour
{
    public GameObject[] myVisible;
    public float spd = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoVis() {

        StartCoroutine(myGoAlfa());

    }


    IEnumerator myGoAlfa() {

        for (int i = 0; i < myVisible.Length; i++) myVisible[i].GetComponent<CanvasGroup>().alpha = 0f;


        for (int i = 0; i < myVisible.Length; i++) {


            while (myVisible[i].GetComponent<CanvasGroup>().alpha <= 0.99f) {

                myVisible[i].GetComponent<CanvasGroup>().alpha += spd * Time.deltaTime;

                yield return null;

            }


            myVisible[i].GetComponent<CanvasGroup>().alpha = 1f;

            yield return null;

        }




        yield return null;
    }



}
