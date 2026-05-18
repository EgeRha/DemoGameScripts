using UnityEngine;
using TMPro;

public class PlayerAttack : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 1f;

    public int stamina = 5;
    public int maxStamina = 5;

    public TextMeshProUGUI staminaText;

    private Animator anim;

    private float staminaTimer;
    public float staminaRecoveryTime = 1f;

    void Start()
    {
        UpdateStaminaUI();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && stamina > 0)
        {
            stamina--;

            UpdateStaminaUI();

            Attack();

            anim.SetTrigger("Attack");
        }

        if (stamina < maxStamina)
        {
            staminaTimer += Time.deltaTime;

            if (staminaTimer >= staminaRecoveryTime)
            {
                stamina++;
                stamina = Mathf.Clamp(stamina, 0, maxStamina);

                UpdateStaminaUI();

                staminaTimer = 0f;
            }
        }


    }

    void Attack()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(
            attackPoint.position,
            attackRange
        );

        foreach (Collider2D hit in hits)
        {
            if (hit.CompareTag("Enemy"))
            {
                Destroy(hit.gameObject);
            }
        }
    }

    void RecoverStamina()
    {
        // yavaş dolum
        stamina += 1;
        stamina = Mathf.Clamp(stamina, 0, maxStamina);

        UpdateStaminaUI();
    }

    void UpdateStaminaUI()
    {
        staminaText.text = "Durability: " + stamina;
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}


