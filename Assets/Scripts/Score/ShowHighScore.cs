using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class ShowHighScore : MonoBehaviour
{
    public Text highscore;
    public string filepath;

    void Start()
    {
        filepath = Path.Combine(Application.dataPath, "Score", "Scripts", "score.txt");
        Debug.Log(filepath);
    }

    public void InsertOrShow(string score)
    {
        int numscore = Convert.ToInt32(score);
        int currenthighscore = Convert.ToInt32(ShowHighCurrentScore());

        if (numscore > currenthighscore)
        {
            highscore.text = score;
            InsertNewHighscore(score);
        }
        else
        {
            highscore.text = ShowHighCurrentScore();
        }

    }
    public string ShowHighCurrentScore()
    {

        if (File.Exists(filepath))
        {
            string scoreText = File.ReadAllText(filepath);
            return scoreText;
        }
        else
        {
            Debug.Log("High score file does not exist.");
            return "0";
        }
    }
    public void InsertNewHighscore(string score)
    {
        try
        {
            File.WriteAllText(filepath, string.Empty);
            File.WriteAllText(filepath, score);
            Console.WriteLine("Text successfully written to the file.");
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred while writing to the file: " + e.Message);
        }
    }
}
