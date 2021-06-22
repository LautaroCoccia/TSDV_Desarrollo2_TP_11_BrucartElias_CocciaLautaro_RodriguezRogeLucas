using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Layer", menuName = "Layers/Layer" + "", order = 1)]
public class Layer : ScriptableObject
{
	public Transform pos;
	public Sprite layer;
	public float moveCameraRatio = 0;
	public float moveCameraRatioY = 0;
}
