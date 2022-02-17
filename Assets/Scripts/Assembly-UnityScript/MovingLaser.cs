using System;
using UnityEngine;

[Serializable]
public class MovingLaser : MonoBehaviour
{
	public GameObject laserShootPoint;
	public Transform dummyStartPos;
	public Transform dummyEndPos;
	public float laserEffectiveDistance;
	public float speed;
}
