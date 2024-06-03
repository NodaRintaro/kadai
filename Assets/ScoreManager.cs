using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager _scoreInstance = new ScoreManager();

    [SerializeField] GameObject _gameObject;

    private int _score = 0;

    Text _text;

    void Start()
    {
        _text = _gameObject.GetComponent<Text>();
        _text.text = _score.ToString("000");
    }

    public static ScoreManager Instance()
    { 
        return _scoreInstance; 
    }

    public void Score(int score)
    {
        _score += score;
        _text.text = _score.ToString("000");
    }
}
