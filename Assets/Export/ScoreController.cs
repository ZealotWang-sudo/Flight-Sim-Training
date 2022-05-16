using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro scoreCounter;
    public TextMeshPro mistakeCounter;
    public int points = 0;
    public int mistake = 0;
    public static ScoreController instance;
    void Start()
    {
        instance = this;
    }
    public void addOnePoint()
    {
        points++;
        scoreCounter.text = "Hit: " + points;
    }
    public void addOneMistake()
    {

        mistake++;

        mistakeCounter.text = "Mis-hit: " + mistake;
    }
    public void reset()
    {
        points = 0;
        mistake = 0;
        scoreCounter.text = "Hit: 0";
        mistakeCounter.text = "Mis-hit: 0";
    }
    // Update is called once per frame
}
