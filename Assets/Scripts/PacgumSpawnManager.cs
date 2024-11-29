using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacgumSpawnController : MonoBehaviour
{
    public GameObject pacGum;

    enum Location
    {
        TopLeftX = -5,
        TopLeftY = 2,

        TopRightX = 5,
        TopRightY = 4,

        BottomLeftX = -8,
        BottomLeftY = -4,

        BottomRightX = 9,
        BottomRightY = -3
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(0, 0, 0); // default needed for the compiler
        
        // Choose a random location
        int randomInt = Random.Range(0, 4);
        switch(randomInt) {
            case 0:
                pos = new Vector3((float) Location.TopLeftX, (float) Location.TopLeftY, 0);
                break;
            case 1:
                pos = new Vector3((float) Location.TopRightX, (float) Location.TopRightY, 0);
                break;
            case 2:
                pos = new Vector3((float) Location.BottomLeftX, (float) Location.BottomLeftY, 0);
                break;
            case 3:
                pos = new Vector3((float) Location.BottomRightX, (float) Location.BottomRightY, 0);
                break;
        }

        Instantiate(pacGum, pos, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
