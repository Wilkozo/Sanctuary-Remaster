using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endings : MonoBehaviour
{
   
    public GameObject win;
    public GameObject neutral;
    public GameObject lose;

    private void Start()
    {
        win.SetActive(false);
        neutral.SetActive(false);
        lose.SetActive(false);


        if (NPCBreakUp.Hope >= 90 && NPCDrunk.Hope >= 90 && NPCFat.Hope >= 90 && NPCPastor.Hope >= 90 && NPCPoor.Hope >= 90 && NPCArtistStats.Hope >= 90)
        {
            win.SetActive(true);
        }
        if (NPCBreakUp.Hope <= 90 || NPCDrunk.Hope <= 90 || NPCFat.Hope <= 90 || NPCPastor.Hope <= 90 || NPCPoor.Hope <= 90 || NPCArtistStats.Hope <= 90)
        {
            neutral.SetActive(true);
        }
        if (NPCBreakUp.Hope <= 0 && NPCDrunk.Hope <= 0 && NPCFat.Hope <= 0 && NPCPastor.Hope <= 0 && NPCPoor.Hope <= 0 && NPCArtistStats.Hope <= 0)
        {
            lose.SetActive(true);
        }
 
    }

    public void ReturnToMenu() {
        NPCArtistStats.Hope = 0;
        NPCPastor.Hope = 0;
        NPCBreakUp.Hope = 0;
        NPCDrunk.Hope = 0;
        NPCFat.Hope = 0;
        NPCPoor.Hope = 0;
        PlayerStats.Hope = 0;
        GlobalData.Day = 1;
        GlobalData.GetSetCurrentActions = 0;
        SceneManager.LoadScene("MainMenu");
    }

}
