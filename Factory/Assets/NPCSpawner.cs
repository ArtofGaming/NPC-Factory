using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;
    private INPC m_Adventurer;
    //check
    public void SpawnVillagers()
    {
        m_Adventurer = m_Factory.GetNPC(NPCType.Adventurer);
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);


        //m_Beggar.Speak();
        //m_Farmer.Speak();
        //m_Shopowner.Speak();
    }
}
