using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _sizeToGrowSize;
    [SerializeField] private float _sizeToGrowCenter;
    private bool _finishShoot;

    void Start()
    {
        _finishShoot = false;
    }

    void LateUpdate()
    {
        ResizeColliders();
    }

    private void ResizeColliders()
    {
        if (!_finishShoot)
        {
            GetComponent<BoxCollider>().size += new Vector3(0, _sizeToGrowSize, 0);
            GetComponent<BoxCollider>().center += new Vector3(0, _sizeToGrowCenter, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ceil"))
        {
            _finishShoot = true;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            Destroy(this.gameObject, 2);
        }
    }
}