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

    void Start()
    {
        StartCoroutine(SpawnPacgum());
    }

    IEnumerator SpawnPacgum()
    {
        while (true)
        {
            Vector3 pos = new Vector3(0, 0, 0);
            
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

            GameObject newPacGum = Instantiate(pacGum, pos, Quaternion.identity);
            newPacGum.tag = "Pacgum";


            yield return new WaitForSeconds(3.0f);
        }
    }
}
