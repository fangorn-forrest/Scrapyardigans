using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class PlayerVariables : MonoBehaviour {

    public static PlayerVariables playerVars;
    
    //Basic Player Data
    public static string playerName;
    public static int playerMoney;

    //Last Scene Loaded
    public static string lastScene;

    //Basic Ship Data
    public static string shipName;
    public static int shipFuel;

    //Sector Passes
    public static int bytoPass;
    public static int sevenPass;
    public static int erwPass;

}
