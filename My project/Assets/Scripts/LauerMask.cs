using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LayerMaskUtil
{
    public static bool ContainsLayer(LayerMask layerMask, GameObject gameObject)
    {
        return (layerMask.value & 1 << gameObject.layer) > 0;
    }
}
