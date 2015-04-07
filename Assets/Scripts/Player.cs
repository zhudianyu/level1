﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float m_speed = 1;
	protected Transform m_transform;
	public Transform m_rocket;
	float m_rocketRate =0;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		float movev = 0;
		float moveh = 0;
		if (Input.GetKey (KeyCode.UpArrow)) {
						movev -= m_speed * Time.deltaTime;
				}
		if (Input.GetKey (KeyCode.DownArrow))
		{
			movev += m_speed*Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			
			moveh += m_speed*Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			moveh -= m_speed * Time.deltaTime;
		}
		m_rocketRate -= Time.deltaTime;
		if (m_rocketRate <= 0) {
			m_rocketRate = 0.1f;
			if (Input.GetKey (KeyCode.Space) || Input.GetMouseButton (0)) {
				Instantiate(m_rocket,m_transform.position,m_transform.rotation);
			}
				}

		this.m_transform.Translate(new Vector3(moveh,0,movev));
	}
}
