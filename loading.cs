using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    [SerializeField]
    private GameObject gunc;
    public Slider Slider;
    public Text Text;
    // Start is called before the first frame update
    void Awake()
    {
        gunc.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    public void LoadLevelButton(int level)
    {
        gunc.gameObject.SetActive(true);
        StartCoroutine(LoadLevelAsync(level));
    }

    // Use this for initialization
    IEnumerator LoadLevelAsync(int LevelIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(LevelIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            Slider.value = progress;
            Text.text = progress * 100 + "%";
            yield return null;

        }

    }

}

