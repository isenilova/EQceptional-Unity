using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskNumChangeExersise : MonoBehaviour
{
    public GameObject myTaskNum;
    int cnt = 1;
    public GameObject myLamp;

    public GameObject myTasks;
    public GameObject myFinish;

    public int myNum = 0;

    private void OnEnable()
    {
        cnt = 1;
        myTaskNum.GetComponent<Text>().text = "Task " + cnt.ToString() + "/10";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlusTask() {

        cnt++;
        myTaskNum.GetComponent<Text>().text = "Task " + cnt.ToString() + "/10";

        if (cnt == 11)
        {
            if (!GameController.playerparams.tasks[myNum])
            {
                myLamp.SetActive(false);
                GameController.playerparams.tasks[myNum] = true;
                GameController.Save();
            }
            myTasks.SetActive(false);
            myFinish.SetActive(true);
            cnt = 1;
            myTaskNum.GetComponent<Text>().text = "Task " + cnt.ToString() + "/10";

        }
    }
}
