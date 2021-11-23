using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAutoClickRepair : MonoBehaviour
{

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCarbon;
    public static int carbonValue = 5;
    public static bool turnOffButton = false;


    void Update()
    {
        currentCarbon = GlobalCarbon.CarbonCount;
        fakeText.GetComponent<Text>().text = "Repair Skeleton - " + carbonValue + " carbon";
        realText.GetComponent<Text>().text = "Repair Skeleton - " + carbonValue + " carbon";
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
