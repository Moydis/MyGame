using UnityEngine;
using UnityEngine.UI;

public class LvL9O4 : MonoBehaviour
{
    [SerializeField] private float movementDistance;
    [SerializeField] private float speed;

    
    private bool movingDown;
    private float leftEdge;
    private float rightEdge;

    private void Awake()
    {
        GameObject.Find("FunSlider");
       
        leftEdge = transform.position.z - movementDistance;
        
        rightEdge = transform.position.z + movementDistance;
    }

    private void Update()
    {
        if (movingDown)
        {
            if (transform.position.z > leftEdge)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y * Time.deltaTime, transform.position.z - speed);
            }
            else
                movingDown = false;
        }
        else
        {
            if (transform.position.z < rightEdge)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y * Time.deltaTime, transform.position.z + speed);
            }
            else
                movingDown = true;
        }
    }
}
