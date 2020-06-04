using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBg : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        if (StartGame.isStart)
        {
            gameObject.transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
    }
}
