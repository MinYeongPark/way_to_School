// Scene1 - ������ ���� ���� ���� ��ȭ�� �� ��ȭâ �����ϴ� �ڵ�
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S1_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S1_DialogueSystem system;

	public Animator anim_image;
	public Animator NextDialogue1, // �Ĵ翡�� �� �� ���� �����̼�
		            NextDialogue2; // ��������(�̷�)���� ���� ����
	public Animator anim_nextSpot;

	public SpriteRenderer background_image;
	public Sprite sj_current_room;

	// Start is called before the first frame update
	void Start() {
		system = FindObjectOfType<S1_DialogueSystem>();
		system.Begin(info);

		background_image = FindObjectOfType<SpriteRenderer>();

	}

	// Update is called once per frame
	void Update() {
		if (system.finishedCount == 1) {
			anim_image.SetBool("isOpen", true);
		}

		if (system.finishedCount == 2) {
			anim_image.SetBool("isOpen", false);
			NextDialogue1.SetBool("isOpen", true);
		}

		// �������� ��(�̷�)
		if (system.finishedCount == 3) {
			NextDialogue1.SetBool("isOpen", false);
			background_image.sprite = sj_current_room;
			NextDialogue2.SetBool("isOpen", true);
		}

		if (system.finishedCount == 4) {
			NextDialogue2.SetBool("isOpen", false);
			anim_nextSpot.SetBool("isOpen", true);
		}
	}
}
