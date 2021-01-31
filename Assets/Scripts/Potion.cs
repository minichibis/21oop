/** Sam Carpenter
*   Week 1
*   Potion.cs
*   Drink it!
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : Item, Sellable, Throwable
{
	public string effect = "invisibility";
	
	public Potion(string e){
		effect = e;
	}
	
    public override void use(){
		quaff();
	}
	
	public void quaff(){
		Debug.Log("potion quaffed, experienced " + effect);
	}
	
	public void sell(){
		Debug.Log("potion sold");
	}
	
	public void thrown(){
		Debug.Log("potion thrown");
	}
}
