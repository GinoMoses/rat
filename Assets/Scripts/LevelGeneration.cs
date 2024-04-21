using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generation : MonoBehaviour
{

    public GameObject[] rooms;

    // Start is called before the first frame update
    void Start()
    {
        // generate 5 from the rooms array, and place them in the scene, don't repeat the same room twice
        int lastRoom = -1;
        int randomRoom = 0;
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

    // Update is called once per frame
    void Update()
    {
       
    }
}
