using UnityEngine;

public class Button : MonoBehaviour
{
    public float health = 50f;

    public GameObject[] doors;
    public GameObject[] platform;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();

        }
    }
    void Die()
    {
        Destroy(gameObject);

        foreach(var door in doors)
        {
            door.SetActive(false);
        }
        foreach (var platform in platform)
        {
            platform.SetActive(true);
        }
    }

    
}
