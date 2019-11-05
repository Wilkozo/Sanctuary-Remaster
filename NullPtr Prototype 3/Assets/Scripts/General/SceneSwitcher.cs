using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class SceneSwitcher : MonoBehaviour {

    [SerializeField] private GameObject fadePanel;
    [SerializeField] private float fadeTime;
    private Image fadeImage;
    public string targetScene;
    public string curScene;
    public bool isFading;
    public bool isSwitching;
    public float fadeTimeCur;
    private PlayerTarget ptarget;

    void Awake()
    {

        ptarget = FindObjectOfType<PlayerTarget>();
    }

	// Use this for initialization
	void Start ()
    {

        curScene = SceneManager.GetActiveScene().name;
        Debug.Log(curScene);
        if (curScene != "MainMenu")
        {
            GlobalData.LastScene = curScene;

        }

        isFading = true;
        fadeTimeCur = fadeTime;
        fadePanel.SetActive(true);
        fadeImage = fadePanel.GetComponent<Image>();
        Vector4 initialColor = fadeImage.color;
        fadeImage.DOFade(0, fadeTime).SetEase(Ease.InOutSine);
    }
	
	// Update is called once per frame
	void Update ()
    {
        fadeTimeCur = Mathf.MoveTowards(fadeTimeCur, 0f, Time.deltaTime);
        if (fadeTimeCur != 0)
        {
            isFading = true;
        }
        else
        {
            isFading = false;
        }

        if (isSwitching && !isFading && targetScene != null)
        {

            SceneManager.LoadScene(targetScene);
        }

	}

    public void SceneSwitch(string scene)
    {
        if (!isSwitching)
        {
            
            
            Vector4 initialColor = fadeImage.color;
            fadeImage.DOFade(1, fadeTime / 2).SetEase(Ease.InOutSine);
            fadeTimeCur = fadeTime;
            targetScene = scene;
            isSwitching = true;
        }
    }

    public void EnterDoor(string scene)
    {
        if (!isSwitching)
        {
            Vector4 initialColor = fadeImage.color;
            fadeImage.DOFade(1, fadeTime / 2).SetEase(Ease.InOutSine);
            FindObjectOfType<AudioManager>().Play("Door");
            fadeTimeCur = fadeTime;
            targetScene = scene;
            isSwitching = true;
        }
    }

    public void StartFade()
    {
        if (!isSwitching)
        {
            Vector4 initialColor = fadeImage.color;
            fadeImage.DOFade(1, fadeTime / 2).SetEase(Ease.InOutSine);
        }
        isSwitching = true;
        fadeTimeCur = fadeTime;
    }

    public void Sleep()
    {
        if (!isSwitching)
        {
            if (GlobalData.TimeOfDay >= 2)
            {
                Vector4 initialColor = fadeImage.color;
                fadeImage.DOFade(1, fadeTime / 2).SetEase(Ease.InOutSine);
                fadeTimeCur = fadeTime;
                targetScene = "FightClub";
                isSwitching = true;
                GlobalData.Day += 1;
                GlobalData.talkedToArtist = false;
            }
            else
            {
                FindObjectOfType<MessageBox>().DisplayMessage("Now is not the time for sleep", 5f);
            }

        }
    }

    public void EnterWorld()
    {
        StartFade();
        if (!isSwitching)
        {
            FindObjectOfType<AudioManager>().Play("Door");
        }
        targetScene = "WorldScene";
    }

    public void EnterMainMenu()
    {
        StartFade();
        targetScene = "MainMenu";
    }
}
