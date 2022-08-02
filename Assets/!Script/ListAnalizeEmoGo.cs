using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListAnalizeEmoGo : MonoBehaviour
{
    public GameObject myEmoText;

    public GameObject startObj;
    public GameObject endObj;

    public float spd = 5000f;


    private void OnEnable()
    {
        
    }


    // Start is called before the first frame update
    void Start()
    {
        GoBack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GoForw() {

        if (startObj.transform.position.x > endObj.transform.position.x)
        {
            StartCoroutine(myGoLeft());
        }

        else
        {

            StartCoroutine(myGoRight());

        }
        


    }

    public void GoBack() {

        


        transform.position = new Vector3(startObj.transform.position.x, transform.position.y, transform.position.z);

    }


    IEnumerator myGoLeft() {


        while (transform.position.x > endObj.transform.position.x) {

            transform.position = new Vector3(transform.position.x- spd*Time.deltaTime, transform.position.y, transform.position.z);

            yield return null;
        }


        yield return null;
    }

    IEnumerator myGoRight() {

        while (transform.position.x < endObj.transform.position.x)
        {

            transform.position = new Vector3(transform.position.x + spd * Time.deltaTime, transform.position.y, transform.position.z);

            yield return null;
        }




        yield return null;
    }

}
