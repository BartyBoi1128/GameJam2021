
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100f;

    // Start is called before the first frame update
    public void TakeDamage(float amount)
	{
        health -= amount;
        if(health <= 0f)
		{
            Die();
		}

	}

    void Die()
	{
        Destroy(gameObject);
	}
}
