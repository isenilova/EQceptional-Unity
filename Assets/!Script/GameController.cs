using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameParams playerparams = new GameParams();

    // Start is called before the first frame update
    void Awake()
    {
        QualitySettings.vSyncCount = 2;
        Application.targetFrameRate = 45;
       



        Load();

        if (GameController.playerparams.firstDayCheckIn == "")
        {
            GameController.playerparams.firstDayCheckIn = System.DateTime.Now.Date.ToString();
            GameController.Save();


        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load()
    {
        if (PlayerPrefs.HasKey("save"))
        {

            var s = PlayerPrefs.GetString("save");
            playerparams = JsonUtility.FromJson<GameParams>(s);
        }
        else {

            playerparams = new GameParams();
            Save();

        }

       // Debug.Log("LOAD: " + JsonUtility.ToJson(playerparams));


    }

    public static void Save() {


        var s = JsonUtility.ToJson(playerparams);
       // Debug.Log(s);
        PlayerPrefs.SetString("save", s);

    }


}
