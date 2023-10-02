using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endscene : MonoBehaviour
{
    public Text timerText;
    public void Setup(int timer)
    {
        gameObject.SetActive(true);
        timerText.text = timer.ToString()+ " tijd";//dit is mijn highscore(ll)
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("minesweeper");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Main");
    }
}
