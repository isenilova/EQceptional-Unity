using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameParams 
{
    public List<EmoItem> hist = new List<EmoItem>();

    public bool[] tasks = new bool[3];

    public bool[] ach = new bool[4];

    public string firstDayCheckIn = "";

    public bool[] setting = new bool[3];


    public List<EmoItem> customlist = new List<EmoItem>();

    public string nearlogin = "";

    //public bool pushStat = true;


}
