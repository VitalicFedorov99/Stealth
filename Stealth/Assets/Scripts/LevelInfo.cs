using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInfo : MonoBehaviour
{
    [SerializeField] private int _stars;
    [SerializeField] private bool _isComplit;
    [SerializeField] private int _numberLevel;
    private int _maxStars;


    private void Start()
    {
        _stars = PlayerPrefs.GetInt("StarsCount" + _numberLevel.ToString());
        //_maxStars = _stars;
    }

    public void ChooseLevel()
    {
        PlayerPrefs.SetInt("NumberLevel", _numberLevel);    
    }

    public void UpdateStars( int stars)
    {
        if (_maxStars < stars)
        {
            _maxStars = stars;
            _stars = stars;
        }
    }
}
