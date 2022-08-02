using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoCloseAddEmotionTab : MonoBehaviour
{
    public GameObject fstTab;

    public GameObject typeEmoBut;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onMyClose()
    {
        fstTab.GetComponent<Button>().onClick.Invoke();

       // typeEmoBut.GetComponent<emoBut>().myemo.emotion = "custom";

       
    }

}
