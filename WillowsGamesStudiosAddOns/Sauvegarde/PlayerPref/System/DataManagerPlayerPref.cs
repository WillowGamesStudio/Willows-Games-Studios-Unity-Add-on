using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManagerPlayerPref : MonoBehaviour
{

    public void DeleteSave(string DataName)
    {
        PlayerPrefs.DeleteKey(DataName);
    }

    public void DeleteAllSavedData()
    {
        PlayerPrefs.DeleteAll();
    }
}
