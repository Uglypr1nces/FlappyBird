using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    private float timer = 0;
    private float second = 1;
    private int score = 0;

    public Player script;

    public TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>(); 
        textMeshPro.color = Color.red;
    }

    void Update()
    {
        if (timer < second)
        {
            timer += Time.deltaTime;
        }
        else if (timer > second && script.birdAlive)
        {
            score++;
            Debug.Log("score:" + score);
            timer = 0;
            textMeshPro.text = score.ToString();
        }
    }
}
