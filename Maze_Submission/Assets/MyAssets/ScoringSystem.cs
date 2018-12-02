using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour {

    public GameObject CoinText;
    public GameObject grootBabiesText;

    public static int  CoinScore;
    public static int grootBabiesScore;

    public TreeHouseGate treeHouseGardenGate;
    public TreeHouseGate pergolaGardenGate;

    // Update is called once per frame
    void Update () {

        CoinText.GetComponent<Text>().text = "Coins : " + CoinScore;
        grootBabiesText.GetComponent<Text>().text = "Groot Babies : " + grootBabiesScore;

        if (CoinScore == 10)
        {
            treeHouseGardenGate.Unlock();
            CoinText.GetComponent<Text>().text = "Coins : " + CoinScore + " Door Unlocked";
        }
        if (CoinScore == 10 && grootBabiesScore == 5)
        {
            pergolaGardenGate.Unlock();
            grootBabiesText.GetComponent<Text>().text = "Groot Babies : " + grootBabiesScore + " Door Unlocked";
        }
    }
}
