using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemplePlayerPref : MonoBehaviour
{
    #region Unity Plublic
    public SaveDataPlayerPref Save;
    public LoadDataPlayerPref Load;

    public GameObject Player;
    #endregion

    public void Start()
    {
        Load.LoadGameObjectPos(Player);
    }
}
