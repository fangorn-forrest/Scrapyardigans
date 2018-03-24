using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JsonData : MonoBehaviour
{

    string filename = "scrapyardigans_save.json";
    string path;

    GameData gameData = new GameData();

    void Start()
    {
        path = Application.persistentDataPath + "/" + filename;
        Debug.Log(path);
    }


    public void SaveButton()
    {
        gameData.date = System.DateTime.Now.ToShortDateString();
        gameData.time = System.DateTime.Now.ToShortTimeString();
        gameData.playerName = PlayerVariables.playerName;
        gameData.playerMoney = PlayerVariables.playerMoney;
        gameData.shipName = PlayerVariables.shipName;
        gameData.shipFuel = PlayerVariables.shipFuel;
        gameData.bytoPass = PlayerVariables.bytoPass;
        gameData.sevenPass = PlayerVariables.sevenPass;
        gameData.erwPass = PlayerVariables.erwPass;
        gameData.lastScene = SceneManager.GetActiveScene().name;
        SaveData();
    }

    public void LoadButton()
    {
        ReadData();
    }

    void SaveData()
    {
        JsonWrapper wrapper = new JsonWrapper();
        wrapper.gameData = gameData;

        string contents = JsonUtility.ToJson(wrapper, true);
        System.IO.File.WriteAllText(path, contents);
        Debug.Log("Game Saved");
    }

    void ReadData()
    {
        try
        {
            if (System.IO.File.Exists(path))
            {
                string contents = System.IO.File.ReadAllText(path);
                JsonWrapper wrapper = JsonUtility.FromJson<JsonWrapper>(contents);
                gameData = wrapper.gameData;
                PlayerVariables.playerName = gameData.playerName;
                PlayerVariables.playerMoney = gameData.playerMoney;
                PlayerVariables.shipName = gameData.shipName;
                PlayerVariables.shipFuel = gameData.shipFuel;
                PlayerVariables.lastScene = gameData.lastScene;
                SceneManager.LoadScene(gameData.lastScene, LoadSceneMode.Single);
                Debug.Log("Save Loaded");
            }
            else
            {
                Debug.Log("Unable to read the save data, file does not exist.");
                gameData = new GameData();
            }
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }
}
