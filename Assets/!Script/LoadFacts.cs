using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadFacts : MonoBehaviour
{
    public static FactsList allFacts = new FactsList();

    public TextAsset factsTxt;

    public GameObject factObj;
    // Start is called before the first frame update
    void Start()
    {
        /*
        var a = "gluglu";
        allFacts.facts.Add(a);
        allFacts.facts.Add(a);

        var b = JsonUtility.ToJson(allFacts);
        Debug.Log(b);

    */
    }

    private void Awake()
    {
        var s = factsTxt.text;

        allFacts = JsonUtility.FromJson<FactsList>(s);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotRandomFact()
    {



        var k = Random.Range(0, allFacts.facts.Count);

        factObj.GetComponent<Text>().text = allFacts.facts[k];

    }

}
