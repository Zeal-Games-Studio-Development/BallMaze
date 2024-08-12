using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using ZealMVC.Runtime.Manager;

public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI _txtScore;
    private IntValue _score;


    private void Start()
    {
        _score = DataContainer.Instance.Score;
        _txtScore.text = "SCORE: " + _score.Value.ToString();
        _score.AddListener(OnScoreChanged);
    }

    private void OnScoreChanged(int score)
    {
        _txtScore.text = "SCORE: " + _score.Value.ToString();
    }

    private void OnDestroy()
    {
        _score.RemoveListener(OnScoreChanged);
    }

}
