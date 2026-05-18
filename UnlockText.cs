using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class UnlockText : MonoBehaviour
{
    public TextMeshProUGUI textUI;

    IEnumerator Start()
    {
        textUI.text = "EMOTIONS UNLOCKED";
        yield return new WaitForSeconds(2f);

        textUI.text = "WEAPON UNLOCKED";
        yield return new WaitForSeconds(2f);

        textUI.text = "Knife";
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("DarkStreetScene");
    }
}


