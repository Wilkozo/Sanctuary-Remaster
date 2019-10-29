using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustHope : MonoBehaviour {


    public void IncrementHope(int _iAmountBy)
    {

        PlayerStats.Hope += _iAmountBy;
        PlayerStats.Hope = Mathf.Clamp(PlayerStats.Hope, 0, 100);
        Debug.Log(PlayerStats.Hope);
    }

    public void DecrementHope(int _iAmountBy)
    {
        PlayerStats.Hope -= _iAmountBy;
        PlayerStats.Hope = Mathf.Clamp(PlayerStats.Hope, 0, 100);
        Debug.Log(PlayerStats.Hope);
    }
}
