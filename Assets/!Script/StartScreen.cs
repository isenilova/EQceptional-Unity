using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{

    public float spd = 10f;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(MyDis());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MyDis() {

        yield return new WaitForSeconds(1f);

        while (gameObject.GetComponent<CanvasGroup>().alpha > 0.1f)
        {
            gameObject.GetComponent<CanvasGroup>().alpha -= Time.deltaTime * spd;
            yield return null;
        }

        gameObject.SetActive(false);
        yield return null;
    }
}
