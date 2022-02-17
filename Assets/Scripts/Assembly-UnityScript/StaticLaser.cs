using System;
using UnityEngine;

[Serializable]
public class StaticLaser : MonoBehaviour
{
	public bool requireKeyToShutdown;
	public int howManyKeyRequired;
	public GameObject laserRay;
	public float laserOnTime;
	public float laserOffTimeMin;
	public float laserOffTimeMax;
	public float startDelay;
	public AudioClip openSfx;
	public GameObject[] openFx;
}
