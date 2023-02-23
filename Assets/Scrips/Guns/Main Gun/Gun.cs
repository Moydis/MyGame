using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{

    

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    void Start()
    {
       
        for (int i = 0; i < Gamepad.all.Count; i++)
        {
            Debug.Log(Gamepad.all[i].name);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
        if (Gamepad.all.Count > 0)
        {
            if (Gamepad.all[0].rightTrigger.wasPressedThisFrame)
            {
                Shoot();
            }
            



        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
