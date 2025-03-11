using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnNPCTown : MonoBehaviour
{
    private float spawnTimer = 0f;
    public float spawnInterval = 4f;
    private int spawnChance;

    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;
    public GameObject NPC4;
    public GameObject npcSpawnPoint;

    private GameObject npc;
    private int chooseNPC;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if(spawnTimer >= spawnInterval)
        {
            chooseNPC = Random.Range(0,4);

            switch (chooseNPC)
            {
                case 0:
                    npc = Instantiate(NPC1, npcSpawnPoint.transform);
                    break;
                case 1:
                    npc = Instantiate(NPC2, npcSpawnPoint.transform);
                    break;
                case 2:
                    npc = Instantiate(NPC3, npcSpawnPoint.transform);
                    break;
                case 3:
                    npc = Instantiate(NPC4, npcSpawnPoint.transform);
                    break;
            }
            spawnTimer = 0f;
            spawnInterval = Random.Range(25.0f,30.0f);
        }
    }
}
