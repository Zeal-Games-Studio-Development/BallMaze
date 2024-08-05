using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI _txtScore;
    private int _score;

    private void Update()
    {
        
        _score = PlayerPrefs.GetInt("PlayerScore");
        _txtScore.text = "SCORE: " + _score.ToString();
    }
}
