using UnityEngine;
using System.Collections;

public class AmbulanceSirenFlash : MonoBehaviour
{
    public Light[] redLights;
    public Light[] whiteLights;
    public Light[] yellowLights;
    public float flashInterval = 0.3f;

    void Start()
    {
        StartCoroutine(FlashLoop());
    }

    IEnumerator FlashLoop()
    {
        while (true)
        {
            ToggleLights(redLights, true);
            ToggleLights(whiteLights, false);
            ToggleLights(yellowLights, false);
            yield return new WaitForSeconds(flashInterval);

            ToggleLights(redLights, false);
            ToggleLights(whiteLights, true);
            ToggleLights(yellowLights, false);
            yield return new WaitForSeconds(flashInterval);

            ToggleLights(redLights, false);
            ToggleLights(whiteLights, false);
            ToggleLights(yellowLights, true);
            yield return new WaitForSeconds(flashInterval);
        }
    }

    void ToggleLights(Light[] lights, bool state)
    {
        foreach (var light in lights)
            if (light != null)
                light.enabled = state;
    }
}
