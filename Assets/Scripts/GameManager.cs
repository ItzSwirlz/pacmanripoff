using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }

    private int score = 0;

    void Awake()
    {
        if(_instance != null && _instance != this) {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }

    void Start()
    {

    }

    void Update()
    {
    }

    public void AddScore(int val)
    {
        score += val;
    }

    public int GetScore()
    {
        return score;
    }

}
