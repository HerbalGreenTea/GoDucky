using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject audioPrefab;

    private void Awake()
    {
        GameObject[] arrMusicObj = GameObject.FindGameObjectsWithTag("Music");

        if (arrMusicObj.Length == 0)
        {
            GameObject audioObj = Instantiate(audioPrefab, new Vector2(0, 0), Quaternion.identity);
            DontDestroyOnLoad(audioObj);
        }
    }
}
