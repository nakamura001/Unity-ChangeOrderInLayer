using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PolygonCollider2D))]
public class Box : MonoBehaviour {
	Vector3 dragOffset;
	Manager manager;

	void Start () {
		manager = transform.parent.gameObject.GetComponent<Manager>();
	}
	
	void OnMouseDown() {
		manager.ChangeForegroundRenderer(gameObject.renderer.sortingOrder);
		dragOffset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
	}
	
	void OnMouseDrag() {
		Vector3 screenPoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
		transform.position = screenPoint + dragOffset;
	}
}