using UnityEngine;

public class ColliderHelper : MonoBehaviour
{
	private IColliderHelper colliderHelper;

	private void Start()
	{
		colliderHelper = GetComponentInParent<IColliderHelper>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (colliderHelper == null) Start();
		colliderHelper.EnterCollider(other, transform);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (colliderHelper == null) Start();
		colliderHelper.EnterCollider(collision.collider, transform, collision);
	}

	private void OnTriggerStay(Collider other)
	{
		if (colliderHelper == null) Start();
		colliderHelper.StayCollider(other, transform);
	}

	private void OnCollisionStay(Collision collision)
	{
		if (colliderHelper == null) Start();
		colliderHelper.StayCollider(collision.collider, transform, collision);
	}

	private void OnTriggerExit(Collider other)
	{
		if (colliderHelper == null) Start();
		colliderHelper.ExitCollider(other, transform);
	}

	private void OnCollisionExit(Collision collision)
	{
		if (colliderHelper == null) Start();
		colliderHelper.ExitCollider(collision.collider, transform, collision);
	}
}
