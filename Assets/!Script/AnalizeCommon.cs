using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalizeCommon : MonoBehaviour
{
    public GameObject[] myEmo;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {
        for (int i = 0; i < myEmo.Length; i++) {

            myEmo[i].GetComponent<ListAnalizeEmoGo>().GoBack();
            myEmo[i].GetComponent<ListAnalizeEmoGo>().GoForw();


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
