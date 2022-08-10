using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{

	public GameObject inventoryPanel;
	bool activeInventory = false;	// �κ��丮 Ȱ��ȭ ����

	public Slot[] slots;
	public Transform slotHolder;

    void Start()
    {
		inventoryPanel.SetActive(activeInventory);
		slots = slotHolder.GetComponentsInChildren<Slot>();
	}

	public void InventoryOpen()     // �κ� ��ư Ŭ�� �� �κ��丮 ����
	{
		activeInventory = !activeInventory;
		inventoryPanel.SetActive(activeInventory);
	}
}
