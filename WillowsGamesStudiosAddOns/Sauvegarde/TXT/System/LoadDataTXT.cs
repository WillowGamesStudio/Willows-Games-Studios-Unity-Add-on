using System;
using UnityEngine;

public class LoadDataTXT : MonoBehaviour
{

    #region Unity Public
    public DataManagerTXT SaveSystem;
    #endregion

    ///////////////////////////////////////////////////////// Load Function
    public string LoadStrings(string DataKey)
    {
        foreach (string Data in SaveSystem.ReadData().Split('\n'))
        {
            if (Data.Split('=')[0] == DataKey)
            {
                return Data.Split('=')[1];
            }
        }
        Debug.LogWarning("Key Not Found, Default value returned : ''");
        return "";
    }

    public int LoadInt(string DataKey)
    {
        foreach (string Data in SaveSystem.ReadData().Split('\n'))
        {
            if (Data.Split('=')[0] == DataKey)
            {
                return Convert.ToInt32(Data.Split('=')[1]);
            }
        }
        Debug.LogWarning("Key Not Found, Default value returned : 0");
        return 0;
    }

    public float LoadFloat(string DataKey)
    {
        foreach (string Data in SaveSystem.ReadData().Split('\n'))
        {
            if (Data.Split('=')[0] == DataKey)
            {
                return Convert.ToSingle(Data.Split('=')[1]);
            }
        }
        Debug.LogWarning("Key Not Found, Default value returned : 0");
        return 0;
    }

    public bool LoadBool(string DataKey)
    {
        foreach (string Data in SaveSystem.ReadData().Split('\n'))
        {
            if (Data.Split('=')[0] == DataKey)
            {
                return Convert.ToBoolean(Data.Split('=')[1]);
            }
        }
        Debug.LogWarning("Key Not Found, Default value returned : false");
        return false;
    }

    ///////////////////////////////////////////////////////// Exemple Function

    public void LoadGameObjectPos(GameObject gameObject)
    {
        string DataName = gameObject.name + ":TAG:" + gameObject.tag;

        float PosX = LoadFloat(DataName + "PosX");
        float PosY = LoadFloat(DataName + "PosY");
        float PosZ = LoadFloat(DataName + "PosZ");

        gameObject.transform.position = new Vector3(PosX, PosY, PosZ);
    }
}
