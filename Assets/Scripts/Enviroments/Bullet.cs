using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _sizeToGrowSize;
    [SerializeField] private float _sizeToGrowCenter;


    void FixedUpdate()
    {
        ResizeColliders();
    }

    private void ResizeColliders()
    {
        GetComponent<BoxCollider>().size += new Vector3(0, _sizeToGrowSize, 0);
        GetComponent<BoxCollider>().center += new Vector3(0, _sizeToGrowCenter, 0);
    }
}