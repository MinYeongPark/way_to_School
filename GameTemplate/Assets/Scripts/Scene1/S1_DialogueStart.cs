// Scene1 - ��ȭâ ���� & ������ ���� ��� �����ϴ� �ڵ�
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S1_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S1_DialogueSystem system;

	public Animator anim_image;      // ���� �̹���
	public Animator anim_after1hour, // �Ĵ翡�� �� �� ���� �����̼�
		            anim_smartphone; // ��������(�̷�)���� ���� ���� ����Ʈ��
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
			anim_after1hour.SetBool("isOpen", true);
		}

		// �������� ��(�̷�)
		if (system.finishedCount == 3) {
			anim_after1hour.SetBool("isOpen", false);
			background_image.sprite = sj_current_room;
			anim_smartphone.SetBool("isOpen", true);
		}

		if (system.finishedCount == 4) {
			anim_smartphone.SetBool("isOpen", false);
			anim_nextSpot.SetBool("isOpen", true);
		}
	}
}
