// �����̸� ���ϴ� ���� ��ȭâ �����ϴ� �ڵ�
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSingleStart : MonoBehaviour
{
	public SingleDialogue info;

	// Start is called before the first frame update
	void Start() {
		var system = FindObjectOfType<DialogueSingleSystem>();
		system.Begin(info);
	}
}
