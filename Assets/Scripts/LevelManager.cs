using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZealMVC.Runtime.Manager;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private IntValue _level;
    [SerializeField] private List<LevelData> Listlevel;
    [SerializeField] private LevelValue _currentlevel;




    private void Start()
    {
        _level = DataContainer.Instance.Level;
        _currentlevel = DataContainer.Instance.LevelData;
        
        _level.AddListener(OnLevelChanged);
        _currentlevel.AddListener(OnLevelDataChanged);
        LoadLevel();

    }

    private void Update()
    {
        
        LoadLevel();
        
    }

    private void LoadLevel()
    {
        foreach (LevelData level in Listlevel)
        {
            if (level.Level == _level.Value)
            {
                _currentlevel.Value = level;     
                level.levelPrefab.SetActive(true); 
            }
            else
            {
                level.levelPrefab.SetActive(false);
            }
        }

    }

    public void OnLevelChanged(int level)
    {
        Debug.Log("CAHNGE LEVEL: " + level.ToString());   
    }

    public void OnLevelDataChanged(LevelData levelValue)
    {
        BallMove.Instance.transform.position = BallMove.Instance.startPosision;
        Debug.Log(levelValue.levelPrefab.name.ToString() );
        
    }

    private void OnDestroy()
    {
        _level.RemoveListener(OnLevelChanged);
        _currentlevel.RemoveListener(OnLevelDataChanged);
    }

}
