using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerSample : MonoBehaviour
{
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Weapon weapon1 = new Weapon(100,"Klash");
        Weapon weapon2 = new Weapon(200,"G3");

        weapon1.Weapons();
        weapon2.Weapons();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,100))
            {
                agent.destination = hit.point;
            }
        }
        
    }
}
public class Weapon
{
    public int price;
    public string name;

    public Weapon(int myprice, string myname)
    {
        price = myprice;
        name = myname;
    }
    public void Weapons()
    {
        Debug.Log($"{name} is a weapon which costs {price}");
    }
}
