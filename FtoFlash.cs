using UnityEngine;
using System.Collections;

public class FtoFlash : MonoBehaviour
{
    private bool flashlightEnabled;
    public GameObject flashlight;
    public GameObject lightObj;
    public float maxEnergy;
    public float currentEnergy;

    void Start()
    {
        currentEnergy = maxEnergy;
        maxEnergy = 100;
        currentEnergy = maxEnergy;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            flashlightEnabled =! flashlightEnabled;
        }
        if (flashlightEnabled)
        {
            flashlight.SetActive(true);
            currentEnergy -= 0.5f * Time.deltaTime;
            if (currentEnergy <= 0)
            {
                lightObj.SetActive(false);

            }
        }else
        {
            flashlight.SetActive(false);
            currentEnergy += 1f * Time.deltaTime;
            
        }
        if (currentEnergy > maxEnergy)
        {
            currentEnergy = maxEnergy;
        }
    }
}
