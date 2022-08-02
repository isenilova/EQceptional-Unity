using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoChangeAlfa : MonoBehaviour
{

    public float spd = 1f;
    // Start is called before the first frame update
    void Start()
    {
        

        StartCoroutine(goVis());
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    IEnumerator goVis()
    {

        gameObject.GetComponent<CanvasGroup>().alpha = 0f;

        while (gameObject.GetComponent<CanvasGroup>().alpha < 1f)
        {

            gameObject.GetComponent<CanvasGroup>().alpha += spd * Time.deltaTime;



            yield return null;

        }

        StartCoroutine(goInVis());

        yield return null;
    }


    IEnumerator goInVis()
    {

        gameObject.GetComponent<CanvasGroup>().alpha = 1f;

        while (gameObject.GetComponent<CanvasGroup>().alpha > 0f)
        {

            gameObject.GetComponent<CanvasGroup>().alpha -= spd * Time.deltaTime;



            yield return null;

        }

        StartCoroutine(goVis());

        yield return null;
    }

}
