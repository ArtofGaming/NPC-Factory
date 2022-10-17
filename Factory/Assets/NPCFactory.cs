using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    GameObject me;
    public GameObject cube;
    public GameObject capsule;
    public GameObject cylinder;
    public GameObject sphere;
    INPC current;
    //check
    public INPC GetNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Adventurer:
                me = GameObject.Instantiate(cube);
                me.transform.position = new Vector3(8, 0, 0);
                return null;
            case NPCType.Beggar:
                me = GameObject.Instantiate(capsule);
                me.transform.position = new Vector3(-5, 0, 0);
                return null;
            case NPCType.Farmer:
                me = GameObject.Instantiate(cylinder);
                return null;
            case NPCType.Shopowner:
                me = GameObject.Instantiate(sphere);
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
            if (Physics.Raycast(ray, out hit))
            {
                //Select stage    
                if (hit.transform.name == "Capsule(Clone)")
                {
                    current = new Beggar();
                    current.Speak();
                }
                else if (hit.transform.name == "Cube(Clone)")
                {
                    current = new Adventurer();
                    current.Speak();
                }
                else if (hit.transform.name == "Cylinder(Clone)")
                {
                    current = new Farmer();
                    current.Speak();
                }
                else if (hit.transform.name == "Sphere(Clone)")
                {
                    current = new Shopowner();
                    current.Speak();
                }

            }
        }
    }
}
