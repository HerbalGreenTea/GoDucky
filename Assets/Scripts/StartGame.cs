using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject logoText, scoreText;
    public float hideSpeed = 5f;

    public static bool isStart = false;

    private void Update()
    {
        if (isStart && logoText != null)
            logoText.transform.Translate(Vector2.up * Time.deltaTime * hideSpeed);
    }

    public void startGame()
    {
        if (isStart)
            return;

        isStart = true;
        logoText.GetComponent<Animator>().enabled = false;
        Destroy(logoText, 2f);
        gameObject.GetComponent<Animation>().Play("HideStartButton");

        scoreText.SetActive(true);
    }
}
