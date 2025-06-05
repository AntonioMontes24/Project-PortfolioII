using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private GameObject armsModel;//Tentative might remove later if not going to use it
    [SerializeField] private PlayerWeaponManager weaponManager;

    void Update()
    {
        playerMovement.HandleMove();
        playerMovement.HandleSprint();
        playerMovement.HandleLanding();
        weaponManager.HandleShooting();

        if (Input.GetButtonDown("FireMode"))
        {
            weaponManager.ToggleFireMode();
        }
    }
}
