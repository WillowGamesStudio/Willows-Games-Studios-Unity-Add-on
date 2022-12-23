using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataPlayerPref : MonoBehaviour
{

    ///////////////////////////////////////////////////////// Save Function
    public void SaveStrings(string DataName, string DataToSave)
    {
        PlayerPrefs.SetString(DataName, DataToSave);
    }

    public void SaveInt(string DataName, int DataToSave)
    {
        PlayerPrefs.SetInt(DataName, DataToSave);
    }

    public void SaveFloat(string DataName, float DataToSave)
    {
        PlayerPrefs.SetFloat(DataName, DataToSave);
    }

    ///////////////////////////////////////////////////////// Exemple Function

    public void SaveGameObjectPos(GameObject gameObject)
    {
        string DataName = gameObject.name + gameObject.tag;

        SaveFloat(DataName + "PosX", gameObject.transform.position.x);
        SaveFloat(DataName + "PosY", gameObject.transform.position.y);
        SaveFloat(DataName + "PosZ", gameObject.transform.position.z);
    }
}
