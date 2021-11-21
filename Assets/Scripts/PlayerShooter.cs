using UnityEngine;

// Instantiate a rigidbody then set the velocity

public class PlayerShooter : MonoBehaviour
{
    public PlayerWeapon weapon;

    [SerializeField]
    private Camera cam;

    void Start()
    {
        if (cam == null)
        {
            Debug.LogError("shooter: Missing Camera Reference");
            this.enabled = false;
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            WeaponAction();
        }
    }

    void WeaponAction()
    {

    }
}