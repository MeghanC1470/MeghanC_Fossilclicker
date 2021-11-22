using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAutoClick2 : MonoBehaviour
{

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCarbon;
    public static int carbonValue = 15;
    public static bool turnOffButton = false;
    public GameObject carbonStats;
    public static int numberOfExtracts;
    public static int calciumPerSec;


    void Update()
    {
        currentCarbon = GlobalCarbon.CarbonCount;
        carbonStats.GetComponent<Text>().text = numberOfExtracts + " Extractors extracting " + calciumPerSec + " Calcium per second.";
        fakeText.GetComponent<Text>().text = "Buy Extractor - " + carbonValue + " carbon";
        realText.GetComponent<Text>().text = "Buy Extractor - " + carbonValue + " carbon";
        if (currentCarbon >= carbonValue)
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
