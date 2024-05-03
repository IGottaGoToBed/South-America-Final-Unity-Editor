using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Scoreboard : MonoBehaviour
{
    public Text Score;
    private int score = 0;
    public string filePath = "Assets/Resources/highscores.txt"; // Changed file path

    public DragAndDrop Chile;
    public DragAndDrop Columbia;
    public DragAndDrop Ecuador;
    public DragAndDrop Paraguay;
    public DragAndDrop Peru;
    public DragAndDrop Bolivia;
    public DragAndDrop Argentina;
    public DragAndDrop Brazil;
    public DragAndDrop Venezuela;
    public DragAndDrop Uruguay;

    public int check1 = 0;
    public int check2 = 0;
    public int check3 = 0;
    public int check4 = 0;
    public int check5 = 0;
    public int check6 = 0;
    public int check7 = 0;
    public int check8 = 0;
    public int check9 = 0;
    public int check10 = 0;




    void Start()
    {
        UpdateScoreboard();

    }

    void Update()
    {
        CheckForCorrectAnswers();
    }

    void CheckForCorrectAnswers()
    {
        if (check1 == 0)
        {
            if (Chile.correct)
            {
                AddPoint();
                check1 = 1;
            }
        }
        

        if (check2 == 0)
        {
            if (Columbia.correct)
            {
                AddPoint();
                check2 = 1;
            }
        }

        if (check3 == 0)
        {
            if (Ecuador.correct)
            {
                AddPoint();
                check3 = 1;
            }
        }

        if (check4 == 0)
        {
            if (Paraguay.correct)
            {
                AddPoint();
                check4 = 1;
            }
        }

        if (check5 == 0)
        {
            if (Peru.correct)
            {
                AddPoint();
                check5 = 1;
            }
        }

        if (check6 == 0)
        {
            if (Bolivia.correct)
            {
                AddPoint();
                check6 = 1;
            }
        }

        if (check7 == 0)
        {
            if (Argentina.correct)
            {
                AddPoint();
                check7 = 1;
            }
        }

        if (check8 == 0)
        {
            if (Brazil.correct)
            {
                AddPoint();
                check8 = 1;
            }
        }

        if (check9 == 0)
        {
            if (Venezuela.correct)
            {
                AddPoint();
                check9 = 1;
            }
        }

        if (check10 == 0)
        {
            if (Uruguay.correct)
            {
                AddPoint();
                check10 = 1;
            }
        }
    }

    public void AddPoint()
    {
        score++;
        UpdateScoreboard();
    }

    void UpdateScoreboard()
    {
        Score.text = "Score: " + score.ToString();
    }

    void OnDisable()
    {
        SaveIntegerToFile(score, filePath);
        Debug.Log("Score saved successfully.");
    }

    void SaveIntegerToFile(int number, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(number);
            writer.Close();
        }
    }
}
