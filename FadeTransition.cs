using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class FadeTransition : MonoBehaviour
{
    public Image fadePanel;
    public TextMeshProUGUI messageText;

    public string nextScene;

    public IEnumerator FadeAndLoad()
    {
        Color panelColor = fadePanel.color;

        while (panelColor.a < 1)
        {
            panelColor.a += Time.deltaTime;

            fadePanel.color = panelColor;

            yield return null;
        }

        // yazıyı görünür yap
        Color textColor = messageText.color;
        textColor.a = 1;
        messageText.color = textColor;

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(nextScene);
    }
}

