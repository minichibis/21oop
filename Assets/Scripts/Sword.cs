/** Sam Carpenter
*   Week 1
*   Sword.cs
*   Swing it!
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Item, Sellable, Equippable
{
    public int durability = 3;
	
	public Sword(int d){
		durability = d;
	}
	
	 public override void use(){
		attack();
	}
	
	public void attack(){
		durability--;
		Debug.Log("sword swung. durability is now " + durability);
	}
	
	public void sell(){
		Debug.Log("sword sold");
	}
	
	public void equip(){
		Debug.Log("sword equipped");
	}
}
