using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject Player;

    //Pickup and level completion logic
    public int currentPickups = 0;
    public int maxPickups = 7;
    public bool levelComplete = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
    }


    private void LevelCompleteCheck(){
        
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }
}