using UnityEngine;
using System.Collections;


public class pickUp : MonoBehaviour
{
    [SerializeField] GunStats gun;

    private void Start()
    {
        gun.ammoCur = gun.ammoMax;
    }
}
