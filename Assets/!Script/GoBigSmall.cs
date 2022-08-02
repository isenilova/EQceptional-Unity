using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBigSmall : MonoBehaviour
{
    public float mStep = 1.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void myScale() {


        StartCoroutine(goScale());



    }

    bool mut = false;

    IEnumerator goScale() {

        //transform.localScale = new Vector3(1f, 1f, 1f);
        if (mut) yield break;
        mut = true;

        while (transform.localScale.x < 1.5f) {
            transform.localScale = transform.localScale + new Vector3(mStep * Time.deltaTime, mStep * Time.deltaTime, mStep * Time.deltaTime);
            yield return null;
        }

        while (transform.localScale.x >1.0f)
        {
            transform.localScale = transform.localScale - new Vector3(mStep * Time.deltaTime, mStep * Time.deltaTime, mStep * Time.deltaTime);
            yield return null;
        }

        transform.localScale = new Vector3(1f, 1f, 1f);

        mut = false;
        yield return null;
    }
}
