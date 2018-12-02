using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

    public GameObject topChest;

    Quaternion chestStartRotation;
    Quaternion chestEndRotation;
    float timer = 0f;
    float rotationTime = 10f;

    Boolean openChest = false;

    void Start()
    {
        chestStartRotation = topChest.transform.rotation;
        chestEndRotation = chestStartRotation * Quaternion.Euler(45f, 0f, 0f);
    }


    void Update()
    {
        if (openChest)
        {

            topChest.transform.rotation = Quaternion.Slerp(chestStartRotation, chestEndRotation, timer / rotationTime);
            timer += Time.deltaTime;
        }
    }
        public void OpenChest()
    {
        Debug.Log("'Chest.penChest()' was called");
        openChest = true;
    }
}
