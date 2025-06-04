using UnityEngine;
using System.Collections;

public class PoliceLights : MonoBehaviour
{
    public Light redLight;
    public Light blueLight;
    public float flashInterval = 0.3f;

    void Start()
    {
        StartCoroutine(FlashLoop());
    }

    IEnumerator FlashLoop()
    {
        while (true)
        {
            ToggleLight(redLight, true);
            ToggleLight(blueLight, false);
            yield return new WaitForSeconds(flashInterval);

            ToggleLight(redLight, false);
            ToggleLight(blueLight, true);
            yield return new WaitForSeconds(flashInterval);

            ToggleLight(redLight, false);
            ToggleLight(blueLight, false);
            yield return new WaitForSeconds(flashInterval);
        }
    }

    void ToggleLight(Light light, bool state)
    {
        if (light != null)
            light.enabled = state;
    }
}