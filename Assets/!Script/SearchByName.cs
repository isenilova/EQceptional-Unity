using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchByName : MonoBehaviour
{
    public GameObject myPar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeStr(string cur) {

        //Debug.Log("EDIT " + cur);


        //string s = gameObject.GetComponent<InputField>().textComponent.text;
       

        for (int i = 0; i < myPar.transform.childCount; i++){

            if (cur == "") myPar.transform.GetChild(i).gameObject.SetActive(true);

            else
            {
                if (myPar.transform.GetChild(i).gameObject.GetComponent<emoBut>().myemo.emotion.Length < cur.Length)
                    myPar.transform.GetChild(i).gameObject.SetActive(false);

                else
                {

                    if (myPar.transform.GetChild(i).gameObject.GetComponent<emoBut>().myemo.emotion.Substring(0, cur.Length) != cur)

                        myPar.transform.GetChild(i).gameObject.SetActive(false);

                    else myPar.transform.GetChild(i).gameObject.SetActive(true);
                }
            }
        }





    }

}
