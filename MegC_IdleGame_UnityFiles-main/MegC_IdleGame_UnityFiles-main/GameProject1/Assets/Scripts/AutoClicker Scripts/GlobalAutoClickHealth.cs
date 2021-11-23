using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAutoClickHealth : MonoBehaviour
{

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCalcium;
    public static int calciumValue = 5;
    public static bool turnOffButton = false;


    void Update()
    {
     //   currentCalcium = GlobalCalcium.CalciumCount;
     //   fakeText.GetComponent<Text>().text = "Repair Skeleton - " + calciumValue + " calcium";
     //   realText.GetComponent<Text>().text = "Repair Skeleton - " + calciumValue + " calcium";
     //   if (currentCalcium >= calciumValue)
     //   {
     //       fakeButton.SetActive(false);
    //        realButton.SetActive(true);
     //   }

     //   if (turnOffButton == true)
     //   {
      //      realButton.SetActive(false);
      //      fakeButton.SetActive(true);
      //      turnOffButton = false;
      //  }
    }
}
