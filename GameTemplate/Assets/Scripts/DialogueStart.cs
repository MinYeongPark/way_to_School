// ������ ���� ���� ���� ��ȭ�� �� ��ȭâ �����ϴ� �ڵ�
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStart : MonoBehaviour
{
	public Dialogue info;

	// Start is called before the first frame update
	void Start() {
		var system = FindObjectOfType<DialogueSystem>();
		system.Begin(info);
	}
}
