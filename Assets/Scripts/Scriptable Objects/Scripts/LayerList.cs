using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "LayersList", menuName = "Layers/LayersList" + "", order = 1)]
public class LayerList : ScriptableObject
{
    public List<Layer> layers;
}
