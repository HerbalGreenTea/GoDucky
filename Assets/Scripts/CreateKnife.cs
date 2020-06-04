using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateKnife : MonoBehaviour
{
    public float waitTime = 1f;
    public GameObject knife;

    private bool isSpawn = true;
    private Coroutine spawn;

    private void Update()
    {
        if (StartGame.isStart && isSpawn)
        {
            spawn = StartCoroutine(spawnKnife());
            isSpawn = false;
        }
    }

    IEnumerator spawnKnife()
    {
        while (StartGame.isStart)
        {
            Instantiate(knife, new Vector2(5.91f, Random.Range(-3.34f, -1f)), Quaternion.Euler(new Vector3(0, 0, -45)));
            yield return new WaitForSeconds(waitTime);
        }
        StopCoroutine(spawn);
    }
}
