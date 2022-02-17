using System;
using UnityEngine;

[Serializable]
public class MachineGun : MonoBehaviour
{
	public GameObject gunShootPoint;
	public GameObject bullet;
	public GameObject gunNozzleFire;
	public AudioClip fireSfx;
	public bool smoothFollow;
	public float detectionRange;
	public int MinBullets;
	public int MaxBullets;
}
