using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   int P1Score=0;
   int P2Score=0;

   public TextMeshProUGUI P1ScoreText;
   public TextMeshProUGUI P2ScoreText;

   public void P1True()
   {
    P1Score++;
    P1ScoreText.text=P1Score.ToString();
    CheckScore();
   }

    public void P2True()
   {
    P2Score++;
    P2ScoreText.text=P2Score.ToString();
    CheckScore();
   }

   private void CheckScore()
   {
    if(P1Score==5||P2Score==5)
    {
      SceneManager.LoadScene(2);
    }
   }
}
