using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetUI : MonoBehaviour
{
    public Text aggression;
    public Text submission;
    public Text rationality;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetScores(float a, float s, float r)
    {
        aggression.text = a.ToString("R");
        submission.text = s.ToString("R");
        rationality.text = r.ToString("R");
    }
}
