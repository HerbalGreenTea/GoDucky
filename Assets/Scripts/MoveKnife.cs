using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKnife : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        if (StartGame.isStart)
        {
            gameObject.transform.Translate(Vector2.left * Time.deltaTime * speed, Space.World);

            if (gameObject.transform.position.x <= -6.5f)
            {
                Destroy(gameObject);
            }
        }
    }
}
