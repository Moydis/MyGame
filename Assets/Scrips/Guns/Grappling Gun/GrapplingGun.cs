using UnityEngine;
using UnityEngine.InputSystem;

public class GrapplingGun : MonoBehaviour
{
    private LineRenderer Ir;
    private Vector3 grapplePoint;
    public LayerMask whatIsGrappleable;
    public Transform gunTip, player;
    public new Transform camera;
    private float maxDistance = 100f;
    private SpringJoint joint;
    public Camera fpsCam;

    void Awake()
    {
        Ir = GetComponent<LineRenderer>();
    }

    // Before Late Update is called
    void Update()
    {
        if (Gamepad.all.Count > 1)
        {
            if (Gamepad.all[0].rightTrigger.wasPressedThisFrame)
            {
                StartGrapple();
            }

            else if (Gamepad.all[0].rightTrigger.wasPressedThisFrame)
            {
                StopGrapple();
            }


        }


        if (Input.GetButtonDown("Fire1"))
        {
            StartGrapple();

        }
        else if(Input.GetButtonUp("Fire1"))
        {
            StopGrapple();
        }

    }

    // After Update is called
    void LateUpdate()
    {
        DrawRope();
    }
    void StartGrapple()

    {
         RaycastHit hit;
         if (Physics.Raycast(camera.position, camera.forward, out hit, maxDistance)) { 


            grapplePoint= hit.point;

            joint = player.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = grapplePoint;

            float distanceFromPoint = Vector3.Distance(player.position, grapplePoint);

            // The distance grapple will try to keep you fron grapple point
            joint.maxDistance = distanceFromPoint * 0.8f;
            joint.minDistance = distanceFromPoint * 0.25f;

            // Change theese values to f
            joint.spring = 4.5f;
            joint.damper = 7f;
            joint.massScale = 4.5f;


         }
    }

    void DrawRope()
    {
        Ir.SetPosition(0, gunTip.position);
        Ir.SetPosition(1, gunTip.position);
    }

    void StopGrapple()
    {

    }

}

