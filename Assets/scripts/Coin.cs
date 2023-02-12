using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject winText = new GameObject("WinText");
            winText.transform.SetParent(GameObject.Find("Canvas").transform);

            RectTransform rectTransform = winText.AddComponent<RectTransform>();
            rectTransform.anchoredPosition = Vector2.zero;
            rectTransform.sizeDelta = new Vector2(200, 50);

            Text text = winText.AddComponent<Text>();
            text.text = "WIN";
            text.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
            text.color = Color.yellow;
            text.alignment = TextAnchor.MiddleCenter;
            text.fontSize = 40;

            StartCoroutine(DestroyWinText(winText, 5.0f));
            Destroy(gameObject);
        }
    }

    IEnumerator DestroyWinText(GameObject winText, float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(winText);
    }
}
