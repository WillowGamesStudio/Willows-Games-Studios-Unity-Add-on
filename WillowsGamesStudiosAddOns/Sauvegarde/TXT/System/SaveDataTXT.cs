using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataTXT : MonoBehaviour
{
    #region Unity Public
    public DataManagerTXT SaveSystem;
    #endregion

    ///////////////////////////////////////////////////////// Save Function

    public void SaveInt(string DataKey, int Data)
    {
        SaveSystem.WriteData(DataKey, Data.ToString());
    }

    public void SaveBool(string DataKey, bool Data)
    {
        SaveSystem.WriteData(DataKey, Data.ToString());
    }

    public void SaveFloat(string DataKey, float Data)
    {
        SaveSystem.WriteData(DataKey, Data.ToString());
    }

    public void SaveString(string DataKey, string Data)
    {
        SaveSystem.WriteData(DataKey, Data);
    }

    ///////////////////////////////////////////////////////// Exemple Function
    
    public void SaveGameObjectPos(GameObject gameObject)
    {
        string DataName = gameObject.name + ":TAG:" + gameObject.tag;

        SaveFloat(DataName + "PosX", gameObject.transform.position.x);
        SaveFloat(DataName + "PosY", gameObject.transform.position.y);
        SaveFloat(DataName + "PosZ", gameObject.transform.position.z);
    }
}
