using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour {
	public Item item; // ȹ���� ������
	public Image itemImage;  // �������� �̹���


	// �κ��丮�� ���ο� ������ ���� �߰�
	public void AddItem(Item _item) {
		item = _item;
		itemImage.sprite = item.itemImage;
	}

	// ������ ������ ����
	private void ClearSlot() {
		item = null;
		itemImage.sprite = null;
	}
}
