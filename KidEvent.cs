using UnityEngine;
using System.Collections;

public class KidEvent : MonoBehaviour
{
    public GameObject kid;

    public FadeTransition fadeTransition;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            kid.SetActive(false);

            StartCoroutine(fadeTransition.FadeAndLoad());
        }
    }
}


