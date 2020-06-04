using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSounds : MonoBehaviour
{
    private float waitTime = 3f;
    private Coroutine spawn;
    private AudioSource audio;
    private bool start = true;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (StartGame.isStart && start)
        {
            spawn = StartCoroutine(spawnAudio());
            start = false;
        }
    }

    private IEnumerator spawnAudio()
    {
        while (StartGame.isStart)
        {
            audio.Play();
            yield return new WaitForSeconds(waitTime);
        }
        StopCoroutine(spawn);
    }
}
