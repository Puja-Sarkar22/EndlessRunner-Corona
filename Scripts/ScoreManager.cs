using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    private float score;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            ScoreText.text = ((int)score).ToString();
        }
    }
}
