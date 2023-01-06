using UnityEngine;

public class PlayersPrefDataManager : MonoBehaviour
{
    public void SaveString(string DataToSave, string DataKey)
    {
        PlayerPrefs.SetString(DataKey,DataToSave);
    }

    public void SaveInt(int DataToSave, string DataKey)
    {
        PlayerPrefs.SetInt(DataKey, DataToSave);
    }

    public void SaveFloat(float DataToSave, string DataKey)
    {
        PlayerPrefs.SetFloat(DataKey, DataToSave);
    }

    public void SaveBool(bool DataToSave, string DataKey)
    {
        if (DataToSave) PlayerPrefs.SetInt(DataKey, 1);
        if (!DataToSave) PlayerPrefs.SetInt(DataKey, 0);
    }

    public string LoadString(string DataKey)
    {
        return PlayerPrefs.GetString(DataKey);
    }

    public int LoadInt(string DataKey)
    {
        return PlayerPrefs.GetInt(DataKey);
    }

    public float LoadFloat(string DataKey)
    {
        return PlayerPrefs.GetFloat(DataKey);
    }

    public bool LoadBool(string DataKey)
    {
        if (PlayerPrefs.GetInt(DataKey) == 1) return true;
        return false;
    }

    public void DeleteSaveByKey(string DataKey)
    {
        PlayerPrefs.DeleteKey(DataKey);
    }

    public void DeleteAllSavedData()
    {
        PlayerPrefs.DeleteAll();
    }
}
