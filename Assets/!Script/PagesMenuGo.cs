using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PagesMenuGo : MonoBehaviour
{

    
    public GameObject endobj;
    public float spd = 10000f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoLeft() {


        StartCoroutine(myGoLeft());


    }


    IEnumerator myGoLeft() {

        while (transform.position.x > endobj.transform.position.x) {

            transform.position = new Vector3(transform.position.x - spd * Time.deltaTime, transform.position.y , transform.position.z);

            if(transform.position.x < endobj.transform.position.x) transform.position = endobj.transform.position;

            yield return null;
        }

        transform.position = endobj.transform.position;

        yield return null;

    }

}
