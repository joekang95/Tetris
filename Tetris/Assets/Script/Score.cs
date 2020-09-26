using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text line, score;
    private int lines = 0, scores = 0;
    private void Start()
    {
        line.text = "LINE\n" + lines.ToString("D4");
        score.text = "SCORE\n" + scores.ToString("D5");
    }

    public void AddLine()
    {
        lines++;
        line.text = "LINE\n" + lines.ToString("D4");
    }

    public void AddScore(int i)
    {
        int add = 0;
        switch (i)
        {
            case 1:
                add = 100;
                break;
            case 2:
                add = 400;
                break;
            case 3:
                add = 900;
                break;
            case 4:
                add = 2000;
                break;
        }
        scores += add;
        score.text = "SCORE\n" + scores.ToString("D5");
    }
}
