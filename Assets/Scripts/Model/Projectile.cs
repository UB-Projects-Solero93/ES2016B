﻿using UnityEngine;
using System.Collections;

/**
 * Class that represents the projectile shot by a Weapon
 */
public class Projectile : MonoBehaviour
{
    private float projectileSpeed;
    private CanReceiveDamage target;
	private float damage;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Create the projectile with its properties
	public void create(float projSpeed, CanReceiveDamage target, float damage){
		this.projectileSpeed = projSpeed;
		this.target = target;
		this.damage = damage;
	}

	// Shoot the projectile to the target
	public bool shoot(){
		return this.target.ReceiveDamage (this);
	}

	// Get the projectile damage (defined by weapon)
	public float getDamage(){
		return this.damage;
	}
}