using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] questions;
    public int qNo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AnalyseAnswer();
            DisplayNextQuestion();
        }
    }
    void AnalyseAnswer()
    {

    }
    void DisplayNextQuestion()
    {
        Destroy(questions[qNo]);
        qNo++;
    }

}
