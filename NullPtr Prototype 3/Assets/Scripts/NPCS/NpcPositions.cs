using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NpcPositions : MonoBehaviour
{

    public GameObject Pastor;
    public GameObject Artist;
    public GameObject Pauper;
    public GameObject Fat;
    public GameObject Drunk;
    public GameObject BreakUp;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Awake()
    {

        string curScene = SceneManager.GetActiveScene().name;


        //finding the gameObjects
        Pastor = GameObject.FindGameObjectWithTag("Pastor");
        Artist = GameObject.FindGameObjectWithTag("Artist");
        Pauper = GameObject.FindGameObjectWithTag("Pauper");
        Fat = GameObject.FindGameObjectWithTag("Fat");
        Drunk = GameObject.FindGameObjectWithTag("Drunk");
        BreakUp = GameObject.FindGameObjectWithTag("BreakUp");


        //set positions for the NPCS
        #region testScenePosition

        if (curScene == "TestScene01") {
            switch (GlobalData.Day) {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region storePosition
        if (curScene == "Store")
        {
            switch (GlobalData.Day)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region ChurchPosition
        if (curScene == "Church")
        {
            switch (GlobalData.Day)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                default:
                    break;
            }
        }

        #endregion


        #region ArcadePosition
        if (curScene == "Arcade")
        {
            switch (GlobalData.Day)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region School;Position
        if (curScene == "School")
        {
            switch (GlobalData.Day)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                default:
                    break;
            }
        }

        #endregion







    }
}
