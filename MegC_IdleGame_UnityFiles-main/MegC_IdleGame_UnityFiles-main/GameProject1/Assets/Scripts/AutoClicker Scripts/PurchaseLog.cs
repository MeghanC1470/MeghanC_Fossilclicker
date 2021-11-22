using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCarbon;
    public GameObject AutoCalcium;
    public GameObject RepairSkeleton;
    public PlayerTesr playerHealth;
    public HealthBar healthBar;

    public void StartAutoCarbon()
    {
        AutoCarbon.SetActive(true);
        GlobalCalcium.CalciumCount -= GlobalAutoClick.calciumValue;
        GlobalAutoClick.calciumValue *= 2;
        GlobalAutoClick.turnOffButton = true;
        GlobalAutoClick.carbonPerSec += 1;
        GlobalAutoClick.numberOfShovels += 1;
    }

    public void StartAutoCalcium()
    {
        AutoCalcium.SetActive(true);
        GlobalCarbon.CarbonCount -= GlobalAutoClick2.carbonValue;
        GlobalAutoClick2.carbonValue *= 2;
        GlobalAutoClick2.turnOffButton = true;
        GlobalAutoClick2.calciumPerSec += 1;
        GlobalAutoClick2.numberOfExtracts += 1;
    }

    public void StartRepairSkeleton()
    {
        RepairSkeleton.SetActive(true);
        GlobalCarbon.CarbonCount -= GlobalAutoClickRepair.carbonValue;
        GlobalAutoClickRepair.carbonValue *= 2;
        GlobalAutoClickRepair.turnOffButton = true;
        playerHealth.RepairDamage(10);

    }
}
