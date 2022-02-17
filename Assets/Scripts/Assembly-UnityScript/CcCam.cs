using System;
using UnityEngine;

[Serializable]
public class CcCam : MonoBehaviour
{
	public bool isStatic;
	public float startingRotation;
	public float rotationAngle;
	public float ccCamRotateSpeed;
	public float sideReachWait;
	public AudioClip sirenSfx;
	public AudioClip[] talkSfx;
	public float rayLength;
	public float yOffset;
}
