using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NPCType
{
    Adventurer,
    Beggar,
    Farmer,
    Shopowner
}
public interface INPC
{
    //check
    void Speak();
}
