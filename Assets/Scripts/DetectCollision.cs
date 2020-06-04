using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private Color deathColor = Color.red;
    private SpriteRenderer sr;
    private AudioSource deathAudio;

    public GameObject explosin, panelLose;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        deathAudio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            StartGame.isStart = false;
            Destroy(collision.gameObject.transform.parent.gameObject);
            sr.color = deathColor;

            ContactPoint2D contact = collision.contacts[0];
            Vector3 posCollision = contact.point;
            GameObject exp =  Instantiate(explosin, posCollision, Quaternion.identity) as GameObject;
            Destroy(exp, 1f);
            deathAudio.Play();

            panelLose.SetActive(true);
        }

    }
}
