using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	Box[] boxArray;

	void Start () {
		boxArray = gameObject.GetComponentsInChildren<Box>();
		int count=0;
		foreach(Box box in boxArray) {
			box.renderer.sortingOrder = count++;
		}
	}
	
	public void ChangeForegroundRenderer(int targetOrder) {
		foreach(Box box in boxArray) {
			if (targetOrder == box.renderer.sortingOrder) {
				box.renderer.sortingOrder = boxArray.Length - 1;
			} else if (targetOrder < box.renderer.sortingOrder) {
				box.renderer.sortingOrder--;
			}
		}
	}
}