using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;

    [SerializeField] TMP_Text textScore;

    [SerializeField] Animator plusPoint;
    [SerializeField] Animator minusPoint;

    [SerializeField] AudioSource positiveSound;
    [SerializeField] AudioSource negativeSound;

    // Add points to the score
    public void AddScore(int value)
    {
        score += value;
        textScore.text = "Score: " + score;
        plusPoint.Play("PlusPointAnim");
        positiveSound.Play();
    }

    // Remove point to the score
    public void RemoveScore(int value)
    {
        score -= value;
        textScore.text = "Score: " + score;
        minusPoint.Play("MinusPointAnim");
        negativeSound.Play();
    }
}
