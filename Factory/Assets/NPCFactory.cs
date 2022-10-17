using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    GameObject me;
    INPC current;
    //check
    public INPC GetNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Adventurer:
                me = GameObject.CreatePrimitive(PrimitiveType.Cube);
                me.transform.position = new Vector3(8, 0, 0);
                return null;
            case NPCType.Beggar:
                me = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                me.transform.position = new Vector3(-5, 0, 0);
                return null;
            case NPCType.Farmer:
                me = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                return null;
            case NPCType.Shopowner:
                me = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                me.transform.position = new Vector3(5, 0, 0);
                return null;
        }
        return null;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            /*if (Physics.Raycast(ray, out hit))
            {
                //Select stage    
                if (hit.transform.name == "Capsule")
                {
                    current = new Beggar();
                    current.Speak();
                }
                else if (hit.transform.name == "Cube")
                {
                    current = new Adventurer();
                    current.Speak();
                }
                else if (hit.transform.name == "Cylinder")
                {
                    current = new Farmer();
                    current.Speak();
                }
                else if (hit.transform.name == "Sphere")
                {
                    current = new Shopowner();
                    current.Speak();
                }

            }*/
        }
    }
}
