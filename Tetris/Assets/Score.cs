using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text line;
    private int score = 0;
    private void Start()
    {
        line.text = "Line\n" + score.ToString("D4");
    }

    public void AddLine()
    {
        score++;
        line.text = "Line\n" + score.ToString("D4");
    }
}
