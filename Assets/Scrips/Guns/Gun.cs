using UnityEngine;
<<<<<<< HEAD
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{

    

=======

public class Gun : MonoBehaviour
{
>>>>>>> 1451bab198831dfe01de57e28820cd1434041ac9
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

<<<<<<< HEAD
    void Start()
    {
       
        for (int i = 0; i < Gamepad.all.Count; i++)
        {
            Debug.Log(Gamepad.all[i].name);
        }

    }
=======
>>>>>>> 1451bab198831dfe01de57e28820cd1434041ac9
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
<<<<<<< HEAD
        if (Gamepad.all.Count > 0)
        {
            if (Gamepad.all[0].rightTrigger.isPressed)
            {
                Shoot();
            }
   
            
        }
=======
>>>>>>> 1451bab198831dfe01de57e28820cd1434041ac9
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
