using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemPickUp : MonoBehaviour
{
	// �̿ϼ�
	public GameObject itemButton;
	public Item itemInfo;

	private void Awake() {
	
	}

	private void itemPickUp() {
		itemButton = EventSystem.current.currentSelectedGameObject;
	}
}
