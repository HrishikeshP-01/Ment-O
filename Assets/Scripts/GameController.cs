using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] questions;
    public int qNo = 0;
    public static IDictionary<string, int> responses = new Dictionary<string, int>()
    {
        {"aggressive",0 },
        {"submissive",1 },
        {"rational",2 },
    };
    public float[] score = new float[responses.Count];
    public GameObject uiScreen;
    // Start is called before the first frame update
    void Start()
    {
        questions[qNo].SetActive(true);
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && qNo<questions.Length)
        {
            AnalyseAnswer();
            DisplayNextQuestion();
        }
    }
    void AnalyseAnswer()
    {
        string selection = questions[qNo].GetComponentInChildren<DialogPlaced>().selection;
        score[responses[selection]]++;
        Debug.Log(selection + " " + score[responses[selection]]);
    }
    void DisplayNextQuestion()
    {
        questions[qNo].SetActive(false);
        qNo++;
        if(qNo < questions.Length)
        {
            questions[qNo].SetActive(true);
        }
        else if(qNo == questions.Length)
        {
            CalculateResults();
            DisplayResults();
        }
    }
    void CalculateResults()
    {
        for(int i = 0; i < score.Length; i++)
        {
            score[i] = score[i] / questions.Length * 100;
        }

    }
    void DisplayResults()
    {
        uiScreen.SetActive(true);
        uiScreen.GetComponent<SetUI>().SetScores(score[0],score[1],score[2]);
        GetComponent<SpriteRenderer>().enabled = false;
    }

}
