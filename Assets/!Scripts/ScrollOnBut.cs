using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollOnBut : MonoBehaviour
{
    public bool status = false;
    public GameObject myFill;
    public float spd = 100f;
    float cnt = 0f;
    public int myNum = 0;
    // Start is called before the first frame update
    void Start()
    {
      /*  if (GameParamsController.playerParams.myShareSetting[myNum]) {

            status = true;
            StartCoroutine(goFill());

        }

    */
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeStatus(int i =0) {

        status = !status;

        StartCoroutine(goFill());

        //GameParamsController.playerParams.myShareSetting[i] = status;
        //GameParamsController.Save();

        return;
    }


    IEnumerator goFill() {

        if (status)
        {
            cnt = 0;
            myFill.GetComponent<Image>().fillAmount = 0;
            gameObject.GetComponent<Scrollbar>().value = 0;

            while (cnt < 1f) {

                cnt += spd * Time.deltaTime;
                if (cnt > 1) cnt = 1;
                myFill.GetComponent<Image>().fillAmount = cnt;
                gameObject.GetComponent<Scrollbar>().value = cnt;

                yield return null;
            }


        }
        else {

            cnt = 1;
            myFill.GetComponent<Image>().fillAmount = 1;
            gameObject.GetComponent<Scrollbar>().value = 1;

            while (cnt > 0f)
            {

                cnt -= spd * Time.deltaTime;
                if (cnt < 0) cnt = 0;
                myFill.GetComponent<Image>().fillAmount = cnt;
                gameObject.GetComponent<Scrollbar>().value = cnt;

                yield return null;
            }



        }
        


        yield return null;
    }
}
