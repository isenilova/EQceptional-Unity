using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingOnValueChange : MonoBehaviour
{
    public int myNum = 0;
    bool myOcc = false;

    public GameObject myBut;

    // Start is called before the first frame update
    void Start()
    {
        if (GameController.playerparams.setting[myNum]) myBut.GetComponent<Button>().onClick.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMyChange() {

        if (myOcc) return;


        myOcc = true;

        StartCoroutine(GoChange());

    }

    IEnumerator GoChange() {

        yield return new WaitForSeconds(0.5f);

        if (gameObject.GetComponent<Scrollbar>().value > 0.9f) GameController.playerparams.setting[myNum] = true;


        if (gameObject.GetComponent<Scrollbar>().value < 0.1f) GameController.playerparams.setting[myNum] = false;

        GameController.Save();

        myOcc = false;

        yield return null;
    }
}
