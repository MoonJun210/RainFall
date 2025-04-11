using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public GameObject rain;
    public GameObject rainRed;

    public Text totalScoreTxt;
    int totalScore = 0;

    public Text totalTimeTxt;
    float totalTime = 30.0f;

    public GameObject endPanel;

    private void Awake()
    {
        Time.timeScale = 1f;
        instance = this;
    }


    private void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f);
        InvokeRepeating("MakeRainRed", 0.5f, 2f);

    }

    private void Update()
    {
        if(totalTime > 0f)
        {
            totalTime -= Time.deltaTime;
        } 
        else
        {
            totalTime = 0f;
            endPanel.SetActive(true);
            Time.timeScale = 0f;
        }

        totalTimeTxt.text = totalTime.ToString("N2");

    }

    void MakeRain()
    {
        Instantiate(rain);
    }
    void MakeRainRed()
    {
        Instantiate(rainRed);
    }
    public void AddScore(int score)
    {
        totalScore += score;
        totalScoreTxt.text = totalScore.ToString();
    }

    public void RemoveScore(int score)
    {
        totalScore -= score;
        totalScoreTxt.text = totalScore.ToString();
    }
}
