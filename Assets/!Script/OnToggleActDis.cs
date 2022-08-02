using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnToggleActDis : MonoBehaviour
{
    public GameObject[] myTogleTrue;
    public GameObject myClear;

    public GameObject myPush;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTogglePush(bool val) {

        
            for (int i = 0; i < myTogleTrue.Length; i++) myTogleTrue[i].SetActive(val);

        if (myClear != null) myClear.GetComponent<InputField>().text = "";

        if ((myPush != null) && val) myClear.GetComponent<InputField>().ActivateInputField();
    }

}
