using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coin : MonoBehaviour
{
    [SerializeField]
    private Text mainscoretext;
    [SerializeField]
    private Text scoretext;
    [SerializeField]
    private Text mainscoretexttt;
    [SerializeField]
    private Text scoretexttt;
    public static int score;
    public static int mainscore;
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = PlayerPrefs.GetInt("score").ToString();
        scoretexttt.text = PlayerPrefs.GetInt("score").ToString();
        score = PlayerPrefs.GetInt("score");
        mainscoretext.text = PlayerPrefs.GetInt("mainscore").ToString();
        mainscoretexttt.text = PlayerPrefs.GetInt("mainscore").ToString();
        mainscore = PlayerPrefs.GetInt("mainscore");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();
        PlayerPrefs.SetInt("score", score);
        mainscoretext.text = mainscore.ToString();
        PlayerPrefs.SetInt("mainscore", mainscore);




    }
    public void aa()
    {
        score += 20;
        scoretext.text = score.ToString();
        PlayerPrefs.SetInt("score", score);

    }

}
