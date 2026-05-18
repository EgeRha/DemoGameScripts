using System.Collections;
using UnityEngine;
using TMPro;

public class IntroText : MonoBehaviour
{
    public TextMeshProUGUI introText;

    string[] lines =
    {
        "at the nadir of this hell... a strange feeling overwhelmed me, it is both maddening and comforting  \r\n",
        "In this cruel world, there are cruel and callous people. They don't follow any rules; they can kill whoever they want.\r\n",
        "Is it their fault?"
    };

    void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        foreach (string line in lines)
        {
            introText.text = line;

            yield return new WaitForSeconds(3f);

            introText.text = "";

            yield return new WaitForSeconds(1f);
        }
    }
}

