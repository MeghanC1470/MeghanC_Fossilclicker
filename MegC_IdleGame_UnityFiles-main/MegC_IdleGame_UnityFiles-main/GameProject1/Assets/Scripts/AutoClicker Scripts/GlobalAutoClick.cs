using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAutoClick : MonoBehaviour
{

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCalcium;
    public static int calciumValue = 25;
    public static bool turnOffButton = false;
    public GameObject calciumStats;
    public static int numberOfShovels;
    public static int carbonPerSec;


    void Update()
    {
        currentCalcium = GlobalCalcium.CalciumCount;
        calciumStats.GetComponent<Text>().text = numberOfShovels + " Shovels digging " + carbonPerSec + " Carbon per second.";
        fakeText.GetComponent<Text>().text = "Buy Shovel - " + calciumValue + " calcium";
        realText.GetComponent<Text>().text = "Buy Shovel - " + calciumValue + " calcium";
        if (currentCalcium >= calciumValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
