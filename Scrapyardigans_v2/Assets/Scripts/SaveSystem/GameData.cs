using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    //Date and Time
    public string date = "";
    public string time = "";
    //Basic Player Info
    public string playerName = "";
    public int playerMoney;
    //Basic Ship Info
    public string shipName;
    public int shipFuel;
    //Last Scene Loaded
    public string lastScene;
    //Sector Passes
    public int bytoPass;
    public int sevenPass;
    public int erwPass;
    

}
