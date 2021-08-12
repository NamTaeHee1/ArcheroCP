using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;

public class LoadManager : MonoBehaviour
{
    string JsonData, JsonPath;

    private void Start() {
        JsonPath = Application.dataPath + "/Resources/Gold.json";
        JsonData = File.ReadAllText(JsonPath);  
    }

    private void LoadData()
    {
        JsonData = Regex.Replace(JsonData, @"\D", "");
        GoldManager.Gold = int.Parse(JsonData);
    }
}
