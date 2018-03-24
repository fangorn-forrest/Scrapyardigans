using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewGame : MonoBehaviour {

    public InputField nameField;

    public void ResetVariables()
    {
        //Reset Displayed Player Variables
        PlayerVariables.playerName = "";
        PlayerVariables.playerMoney = 0;
        PlayerVariables.shipName = "";
        PlayerVariables.shipFuel = 100;
        //Set Sector Passes to 0
        PlayerVariables.bytoPass = 0;
        PlayerVariables.sevenPass = 0;
        PlayerVariables.erwPass = 0;
        //
    }

    public void SetNewName()
    {
        PlayerVariables.playerName = nameField.text;
        Debug.Log(PlayerVariables.playerName);
    }
}
