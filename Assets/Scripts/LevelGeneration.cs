using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generation : MonoBehaviour
{

    public GameObject[] rooms;

    void Start()
    {
        int lastRoom = -1;
        int randomRoom;
        for (int i = 0; i < 5; i++)
        {
            while(true) 
            {
                randomRoom = Random.Range(0, rooms.Length);
                if(randomRoom == lastRoom) 
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            lastRoom = randomRoom;
            Instantiate(rooms[randomRoom], transform.position, Quaternion.identity);
            transform.position += new Vector3(25, 0, 0);
        }
    }

    void Update()
    {
        
    }
}
