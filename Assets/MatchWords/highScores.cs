using UnityEngine;
using TMPro;
using System.IO;
using System.Collections.Generic;
using System.Linq;


public class HighScoreManager : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public int testNumber = 0;


    public void UpdateHighScore(int a)
    {
        testNumber = a;
    }

    private void Start()
    {
        string filePath = "Assets/Resources/highscores.txt"; // Changed file path

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            List<int> scores = new List<int>();
            foreach (string line in lines)
            {
                int score;

                
                if (int.TryParse(line, out score))
                {
                    scores.Add(score);
                }
            }

            scores.Sort((a, b) => b.CompareTo(a));

            foreach (int score in scores)
            {
                highScoreText.text += score.ToString() + "\n";
            }
        }
        else
        {
            Debug.LogWarning("High score file not found.");
        }
    }

}