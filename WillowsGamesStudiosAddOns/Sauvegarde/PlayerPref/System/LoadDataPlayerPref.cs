using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDataPlayerPref : MonoBehaviour
{

    ///////////////////////////////////////////////////////// Load Function
    public string LoadStrings(string DataName)
    {
        return PlayerPrefs.GetString(DataName);
    }

    public int LoadInt(string DataName)
    {
        return PlayerPrefs.GetInt(DataName);
    }

    public float LoadFloat(string DataName)
    {
        return PlayerPrefs.GetFloat(DataName);
    }

    ///////////////////////////////////////////////////////// Exemple Function

    public void LoadGameObjectPos(GameObject gameObject)
    {
        string DataName = gameObject.name + gameObject.tag;

        float PosX = LoadFloat(DataName + "PosX");
        float PosY = LoadFloat(DataName + "PosY");
        float PosZ = LoadFloat(DataName + "PosZ");

        gameObject.transform.position = new Vector3(PosX, PosY, PosZ);
    }
}
