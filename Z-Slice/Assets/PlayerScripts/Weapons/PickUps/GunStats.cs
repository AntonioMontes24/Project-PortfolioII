using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu]

public class GunStats : MonoBehaviour
{
    [Header("Weapons Stats")]
    //Weapon Stats
    public GameObject gunModel;
    public int shootDamage;
    public float shootRate;
    public int shootRange;
    public int ammoCur, ammoMax;
    public float reloadTime;

    [Header("Weapon Fire Type")]
    //Fire type
    bool canSwitchFireMode;
    bool isAutomaticDefault;
    public float autoFireRate;
    public float semiFireRate;

    [Header("VFX")]
    //VFX
    public GameObject bulletHolePrefab;
    public ParticleSystem hitEffect;

    [Header("SFX")]
    //Shoot Audio
    public AudioClip shootSound;
    public AudioClip reloadSound;
    public float shootVolume;
}
