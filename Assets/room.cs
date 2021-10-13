using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class room : MonoBehaviour
{
    public bool hasMobs = false;
    public GameObject endPoint;
    public GameObject[] startPoints;
    public bool lockable = false;

    public void LockRoom()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player player = collision.GetComponent<player>();
        if (lockRoom != null&&lockable&& player != null)
        {
            player playerScript = player;
            if (playerScript.bot == false && playerScript.locked == false)
            {
                lockRoom.players = new List<GameObject>();

                player[] players = FindObjectsOfType<player>();

                for(int i=0;i<players.Length;i++)
                {
                    if (players[i].bot == false)
                    {
                        lockRoom.players.Add(players[i].gameObject);
                    }
                }
                lockRoom.enabled = true;
                lockable = false;
            }
        }
    }
    SpriteRenderer spriteRenderer;
    public int mobRoomChance;
    LockRoom lockRoom;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Shops")
            Time.timeScale = 1;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new Color32((byte)(spriteRenderer.color.r * 255), (byte)(spriteRenderer.color.g * 255), (byte)(spriteRenderer.color.b * 255), 0);

        lockRoom = GetComponent<LockRoom>();
    }
    private void OnWillRenderObject()
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);
        Bounds bounds = spriteRenderer.bounds;
        if (GeometryUtility.TestPlanesAABB(planes, bounds))
        {
            spriteRenderer.color = new Color32((byte)(spriteRenderer.color.r*255), (byte)(spriteRenderer.color.g*255), (byte)(spriteRenderer.color.b*255), 255);

        }
    }
}
