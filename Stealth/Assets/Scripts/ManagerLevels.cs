using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLevels : MonoBehaviour
{
    [SerializeField] private LevelInfo[] levels;

    public void UpdateInfoLevels()
    {
        int numberlevel = PlayerPrefs.GetInt("NumberLevel");
        levels[numberlevel - 1].UpdateStars(PlayerPrefs.GetInt("StarsCount"+numberlevel.ToString()));
    }
}
