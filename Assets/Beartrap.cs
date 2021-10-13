using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beartrap : MonoBehaviour
{
    public Sprite activeTrap;
    public AudioClip activate;

    SpriteRenderer spriteRenderer;
    CircleCollider2D circleCollider2D;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        circleCollider2D = GetComponent<CircleCollider2D>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player player = collision.gameObject.GetComponent<player>();
        if(player != null)
        {
            player.DecreaseHp(200, Vector2.zero, null);
            player.Stun(1f);

            spriteRenderer.sprite = activeTrap;

            player.transform.position = transform.position;

            circleCollider2D.enabled = false;

            AudioSource.PlayClipAtPoint(activate, Camera.main.transform.position, PlayerPrefs.GetFloat("SFXVolume", 1));

            Invoke("DestroyObj", 1f);
        }
    }

    void DestroyObj()
    {
        Destroy(gameObject);
    }
}
