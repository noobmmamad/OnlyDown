using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float score = 0.0f;

    

    public float speedFactor = 1.0f;





    void Update()
    {
        speedFactor += Time.deltaTime / 10;

        score += Time.deltaTime * speedFactor;

        scoreText.text = ((int)score).ToString();


        
    }
}