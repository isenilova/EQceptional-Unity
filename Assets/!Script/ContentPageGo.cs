using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentPageGo : MonoBehaviour
{
    public GameObject endobj;
    public float spd = 15000f;
    public GameObject startobj;


    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GoUp() {

        StartCoroutine(myGoUp());
    }

    public void GoDown() {


        StartCoroutine(myGoDown());


    }


    IEnumerator myGoUp()
    {

        while (transform.position.y < endobj.transform.position.y)
        {

            transform.position = new Vector3(transform.position.x , transform.position.y + spd * Time.deltaTime, transform.position.z);

            if(transform.position.y > endobj.transform.position.y) transform.position = endobj.transform.position;

            yield return null;
        }

        transform.position = endobj.transform.position;

        yield return null;

    }


    IEnumerator myGoDown()
    {

        while (transform.position.y > startobj.transform.position.y)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y - spd * Time.deltaTime, transform.position.z);



            yield return null;
        }

        transform.position = startobj.transform.position;

        yield return null;

    }


}
