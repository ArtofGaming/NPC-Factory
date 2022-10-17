using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    GameObject me;
    INPC current;
    public INPC GetNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Adventurer:
                INPC adventurer = new Adventurer();
                me = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                me.transform.position = new Vector3(10, 0, 0);
                return current;
            case NPCType.Beggar:
                INPC beggar = new Beggar();
                me = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                me.transform.position = new Vector3(-10, 0, 0);
                return beggar;
            case NPCType.Farmer:
                INPC farmer = new Farmer();
                me = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                return current;
            case NPCType.Shopowner:
                INPC shopowner = new Shopowner();
                me = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                return shopowner;
        }
        return null;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select stage    
                if (hit.transform.name == "Capsule")
                {
                    current = new Beggar();
                    current.Speak();
                }

            }
        }
    }
}
