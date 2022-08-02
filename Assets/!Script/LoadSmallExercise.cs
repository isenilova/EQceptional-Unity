using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSmallExercise : MonoBehaviour
{
    public GameObject[] myTasks;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < myTasks.Length; i++) {

            if (GameController.playerparams.tasks[i]) myTasks[i].SetActive(false);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
