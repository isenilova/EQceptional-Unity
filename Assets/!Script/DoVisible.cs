using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoVisible : MonoBehaviour
{
    public float spd = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dovisible()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 0f;

        StartCoroutine(goVis());

    }

    IEnumerator goVis() {

        while (gameObject.GetComponent<CanvasGroup>().alpha < 1f) {

            gameObject.GetComponent<CanvasGroup>().alpha += spd * Time.deltaTime;



            yield return null;

        }

        gameObject.GetComponent<CanvasGroup>().alpha = 1f;

        yield return null;
    }

}
