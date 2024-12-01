using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }

    private int score = 0;

    // Awake is called when the GameManager is instantiated
    void Awake()
    {
        // If another instance already exists, get rid of it
        if(_instance != null && _instance != this) {
            Destroy(this.gameObject);
        } else {
            // If no instance exists, make it this one
            _instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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
