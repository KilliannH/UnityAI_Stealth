using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int stealthValue = 0;
    public StealthBar stealthBar;
    public bool isDetected = false;
    public int maxStealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        // reset stealthBar
        stealthBar.SetMaxStealth(maxStealth);
        stealthBar.SetStealth(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(isDetected)
        {
            if (this.stealthValue < maxStealth)
            {
                this.stealthValue++;
                stealthBar.SetStealth(this.stealthValue);
            }
        } else
        {
            if (this.stealthValue > 0)
            {
                this.stealthValue--;
                stealthBar.SetStealth(this.stealthValue);
            }
        }
    }
}
