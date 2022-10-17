using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    private void Start()
    {
        m_SpawnerNPC.SpawnVillagers();
    }
}
