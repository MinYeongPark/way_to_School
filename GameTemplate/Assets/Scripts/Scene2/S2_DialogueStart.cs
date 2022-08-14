// Scene2 - ��ȭâ ���� & ������ ���� ��� �����ϴ� �ڵ�
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S2_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S2_DialogueSystem system;

	public Animator anim_folderphone;  // ������
	public Animator anim_speechBubble, // ������ "������~~" �θ��� ��ǳ��
		            anim_schoolName;   // �������б� ����
	public Animator anim_nextSpot;

	public SpriteRenderer background_image;
	public Sprite wayToSchool;

	// Start is called before the first frame update
	void Start() {
		system = FindObjectOfType<S2_DialogueSystem>();
		system.Begin(info);

		background_image = FindObjectOfType<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update() {
		if (system.finishedCount == 1) {
			anim_folderphone.SetBool("isOpen", true);
		}

		if (system.finishedCount == 2) {
			anim_folderphone.SetBool("isOpen", false);
			anim_speechBubble.SetBool("isOpen", true);
		}

		// ��ϴ� ��
		if (system.finishedCount == 3) {
			anim_speechBubble.SetBool("isOpen", false);
			background_image.sprite = wayToSchool;
			anim_schoolName.SetBool("isOpen", true);
		}

		if (system.finishedCount == 4) {
			anim_schoolName.SetBool("isOpen", false);
			anim_nextSpot.SetBool("isOpen", true);
		}
	}
}
