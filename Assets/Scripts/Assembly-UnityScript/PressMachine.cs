using System;
using UnityEngine;

[Serializable]
public class PressMachine : MonoBehaviour
{
	public GameObject innerPressDetector;
	public GameObject[] outerPressDetector;
	public GameObject leftWing;
	public GameObject rightWing;
	public bool isAutomatic;
	public float startDelay;
	public float closeSpeed;
	public float openSpeed;
	public float delayOfNextPress;
	public bool isPlayerBetweenMyWings;
	public bool isPlayerOutsideMyWings;
}
