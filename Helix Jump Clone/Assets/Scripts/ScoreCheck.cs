using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCheck : MonoBehaviour
{
    public Text scoreText;
    int score;
    private void OnTriggerEnter(Collider other)
    {
        score = int.Parse(scoreText.text)+150;
        scoreText.text = score.ToString();        
        StartCoroutine(CameraSettings.Instance.SetCameraPos());       
    }
}
