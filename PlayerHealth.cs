using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health = 5;

    public TextMeshProUGUI healthText;

    void Start()
    {
        UpdateHealthUI();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        UpdateHealthUI();

        if (health <= 0)
        {
            Debug.Log("Player Died");
        }
    }

    void UpdateHealthUI()
    {
        healthText.text = "Health: " + health;
    }
}
