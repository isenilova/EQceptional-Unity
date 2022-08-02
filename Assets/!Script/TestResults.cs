using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestResults : MonoBehaviour
{
    public GameObject[] myTexts;

    public int[] myNums;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void myAdd(int k) {

        if (k != 0)
        {
            myNums[k]++;
            myTexts[k].GetComponent<Text>().text = myNums[k].ToString();

            myNums[0]--;
            myTexts[0].GetComponent<Text>().text = myNums[0].ToString();

        }
    }

    public void ClearNums() {


        myNums[0] = 10;

        for (int i = 1; i < myNums.Length; i++) myNums[i] = 0;


    }
}
