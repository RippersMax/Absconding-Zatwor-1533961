using System;
using UnityEngine;

[Serializable]
public class PlayerManager : MonoBehaviour
{
	public ControlType controlMode;
	public bool smoothFollow;
	public float speed;
	public AudioClip sirenSfx;
	public AudioClip alertSfx;
	public AudioClip hitSfx;
	public AudioClip[] eatKeySfx;
}
