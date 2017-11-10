using Assets.Scripts;
using UnityEngine;

public class PositionManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (OpaqueDetector.IsOpaque)
        {
            this.gameObject.transform.position = new Vector3(0f, 1f, 1.8f);
        }
        else
        {
            this.gameObject.transform.position = new Vector3(0f, -0.5f, 1.8f);
        }
    }
}
