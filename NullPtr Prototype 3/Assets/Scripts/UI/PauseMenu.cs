using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PauseMenu : MonoBehaviour {

    [SerializeField] private GameObject scriptPiggy;
    [SerializeField] private GameObject pauseMenuPanel;
    private UIHandler uiHandler;
    private CanvasGroup canvas;
    private bool isActive;

	// Use this for initialization
	void Start () {
        uiHandler = scriptPiggy.GetComponent<UIHandler>();
        canvas = GetComponent<CanvasGroup>();
        canvas.alpha = 0;
        //pauseMenuPanel.transform.position = transformInitial;
	}
	
	// Update is called once per frame
	void Update () {

        //float alpha = uiHandler.isPaused ? 1f : 0f;

        //canvas.DOFade(alpha, 0.1f);
        //canvas.interactable = uiHandler.isPaused;
        //canvas.blocksRaycasts = uiHandler.isPaused;

        if (uiHandler.isPaused && !isActive)
        {
            ToggleMenu(1f);
            isActive = true;
        }
        if (!uiHandler.isPaused && isActive)
        {
            ToggleMenu(0f);
            isActive = false;
        }

	}

    public void ToggleMenu(float alpha)
    {
        //float alpha = uiHandler.isPaused ? 1f : 0f;
        canvas.DOFade(alpha, 0.2f);
        canvas.interactable = uiHandler.isPaused;
        canvas.blocksRaycasts = uiHandler.isPaused;
    }
}
