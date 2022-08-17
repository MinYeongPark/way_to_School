using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{

	public GameObject inventoryPanel;
	public Animator anim_inventory;
	public GameObject inventoryCloseBtn;
	public bool activeCloseBtn = false;		//�κ��丮 close ��ư Ȱ��ȭ ����

	public Slot[] slots;
	public Transform slotHolder;

    void Start()
    {
		inventoryCloseBtn.SetActive(activeCloseBtn);
		slots = slotHolder.GetComponentsInChildren<Slot>();
	}

	public void InventoryOpen()     // �κ� ��ư Ŭ�� �� �κ��丮 ����
	{
		anim_inventory.SetBool("InvenBtn", true);
		activeCloseBtn = !activeCloseBtn;
		inventoryCloseBtn.SetActive(activeCloseBtn);		//�κ��丮 ������ư(����) Ȱ��ȭ
	}

	public void InventroyClose() {
		anim_inventory.SetBool("InvenBtn", false);
		activeCloseBtn = !activeCloseBtn;
		inventoryCloseBtn.SetActive(activeCloseBtn);		//�κ��丮 ������ư(����) ��Ȱ��ȭ
	}
}
