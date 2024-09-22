using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawnerGitHub : MonoBehaviour
{
    public int openingDir;
    //1 = need bottom door
    //2 = need top door
    //3 = need left door
    //4 = need right door

    private RoomTemplate roomTemplate;
    private int rand;
    public bool hasSpawned = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SpawnPoint"))
        {
            

            Destroy(gameObject);
        }


        if (other.CompareTag("CenterPoint"))
        {
            /*if (other.GetComponent<RoomSpawner>().hasSpawned == false && hasSpawned == false)
            {
                Instantiate(roomTemplate.closedRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }*/

            Destroy(gameObject);
        }



        hasSpawned = true;
    }
    public void Start()
    {
        roomTemplate = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplate>();
        Invoke("Spawn", 0.8f);
    }
    public void Spawn()
    {
        if (hasSpawned == false)
        {
            if (openingDir == 1)
            {
                //Spawn room with bottom door
                rand = Random.Range(0, roomTemplate.bottomRooms.Length);
                Instantiate(roomTemplate.bottomRooms[rand], transform.position, roomTemplate.bottomRooms[rand].transform.rotation);
            }
            else if (openingDir == 2)
            {
                //Spawn room with top door
                rand = Random.Range(0, roomTemplate.topRooms.Length);
                Instantiate(roomTemplate.topRooms[rand], transform.position, roomTemplate.topRooms[rand].transform.rotation);
            }
            else if (openingDir == 3)
            {
                //Spawn room with left door
                rand = Random.Range(0, roomTemplate.leftRooms.Length);
                Instantiate(roomTemplate.leftRooms[rand], transform.position, roomTemplate.leftRooms[rand].transform.rotation);
            }
            else if (openingDir == 4)
            {
                //Spawn room with right door
                rand = Random.Range(0, roomTemplate.rightRooms.Length);
                Instantiate(roomTemplate.rightRooms[rand], transform.position, roomTemplate.rightRooms[rand].transform.rotation);
            }

            hasSpawned = true;
            Destroy(gameObject);
        }

    }

}
