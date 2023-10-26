using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject levelComp;
    public TextMeshProUGUI scoreText;
    private int score;

    public bool itsOk;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        itsOk = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void GameOver()
    {
        if (itsOk)
        {
            SceneManager.LoadScene("GameOver");
        }
        
    }
    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
        if (score == 15)
        {
            levelComp.SetActive(true);
            itsOk = false;
        }
    }
}
