using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelIngoInGame : MonoBehaviour
{
    [SerializeField] private  int _numberLevel;
    [SerializeField] private int _countStars;
    public void SaveStars()
    {
        PlayerPrefs.SetInt("StarsCount"+_numberLevel.ToString(), _countStars);
    }


    private void Start()
    {
        _numberLevel= PlayerPrefs.GetInt("NumberLevel", _numberLevel);    
    }

}
