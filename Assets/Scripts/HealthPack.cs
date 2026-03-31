using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healAmount = 25;

    void Start()
    {
        Destroy(gameObject, 8f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().Heal(healAmount);
            Destroy(gameObject);
        }
    }
}
