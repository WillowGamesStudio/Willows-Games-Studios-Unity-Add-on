using System.IO;
using UnityEngine;

public class DataManagerTXT : MonoBehaviour
{
    #region VisualStudios Public
    public string SaveFolderName = "Saves";
    public string SaveFileName = "Player1";
    public string SaveFileExtention = "GameSave";
    #endregion

    #region VisualStudios Private
    private string GameFolder;
    private string SaveFolder;
    private string SaveFile;
    #endregion

    void Start()
    {
        GameFolder = Directory.GetCurrentDirectory();
        SaveFolder = Path.Combine(GameFolder, SaveFolderName);

        string FileName = SaveFileName + "." + SaveFileExtention;

        if (!File.Exists(SaveFolder))
        {
            Directory.CreateDirectory(SaveFolderName);
        }

        SaveFile = Path.Combine(SaveFolder, FileName);

        if (!File.Exists(SaveFile))
        {
            File.Create(SaveFile).Close();
        }

        WriteData("Name", SaveFileName);
    }

    public string ReadData()
    {
        return File.ReadAllText(SaveFile);
    }

    public void DeleteSave()
    {
        File.Delete(SaveFile);
    }

    public void WriteData(string Key, string DataToSave)
    {
        string[] DataSaved = ReadData().Split('\n');

        string NewData = "";
        bool KeyFound = false;

        foreach (string Data in DataSaved)
        {
            if(Data.Split('=')[0] == Key)
            {
                NewData += Key + "=" + DataToSave + "\n";
                KeyFound = true;
            }
            else
            {
                if (Data != "")
                {
                    NewData += Data + "\n";
                }
            }
        }

        if (!KeyFound)
        {
            NewData += Key + "=" + DataToSave + "\n";
        }

        File.WriteAllText(SaveFile, NewData);
    }
}
