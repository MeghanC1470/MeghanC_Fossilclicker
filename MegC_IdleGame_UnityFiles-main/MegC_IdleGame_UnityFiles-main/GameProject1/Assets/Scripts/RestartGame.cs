using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    public void LoadGame()
    {
        SceneManager.LoadScene("MainScene");
        GlobalCarbon.CarbonCount = 0;
        GlobalCalcium.CalciumCount = 0;

    }
}
