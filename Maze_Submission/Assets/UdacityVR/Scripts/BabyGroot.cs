using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyGroot : MonoBehaviour {

    // TODO: Create variables to reference the game objects we need access to
    // Declare a GameObject named 'coinPoofPrefab' and assign the 'CoinPoof' prefab to the field in Unity
    public GameObject PoofPrefab;
    public GameObject babyGroot;


    public void OnBabyGrootClicked()
    {
        

        // Prints to the console when the method is called
        Debug.Log("'BabyGroot.OnBabyGrootClicked()' was called");

        
        Instantiate(PoofPrefab, this.transform.position, PoofPrefab.transform.rotation);
        ScoringSystem.grootBabiesScore++;
        Destroy(this.gameObject, 0.5f);
        babyGroot.SetActive(true);
    }
}
