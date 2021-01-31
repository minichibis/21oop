/** Sam Carpenter
*   Week 1
*   Simulator.cs
*   Runs the show.
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Item;

public class Simulator : MonoBehaviour
{
	public List<Item> theitems = new List<Item>();
	public List<Sellable> thesold = new List<Sellable>();
	
    // Start is called before the first frame update
    void Start()
    {
		theitems.Add(new Potion("invisibility"));
		theitems.Add(new Sword(20));
		theitems.Add(new Potion("crit bonus"));
		theitems.Add(new Sword(3));
		thesold.Add(new Sword(2));
		thesold.Add(new Potion("poison"));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
			foreach(Item i in theitems){
				i.use();
			}
		}
		if(Input.GetKeyDown(KeyCode.Alpha2)){
			foreach(Sellable i in thesold){
				i.sell();
			}
		}
    }
}
