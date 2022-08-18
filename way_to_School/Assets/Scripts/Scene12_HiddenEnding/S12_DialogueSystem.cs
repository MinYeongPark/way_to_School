// ������ ���� ���� ���� ��ȭ�� �� ��ȭâ�� ���� �ڵ�
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class S12_DialogueSystem : MonoBehaviour {

	public Text txtSentence;

	Queue<string> sentences = new Queue<string>();

	public Animator anim_window;

	public int finishedCount = 0;

	public void Begin(Dialogue info) {
		anim_window.SetBool("isOpen", true);
		anim_window.SetBool("saidSujeong", true);

		sentences.Clear();

		foreach (var sentence in info.sentences) {
			sentences.Enqueue(sentence);
		}
		Next();
	}

	public void Next() {
		finishedCount++;

		if (sentences.Count == 0) {
			End();
			return;
		}

		txtSentence.text = string.Empty;

		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentences.Dequeue()));
	}

	IEnumerator TypeSentence(string sentence) {
		foreach (var letter in sentence) {
			txtSentence.text += letter;
			yield return new WaitForSeconds(0.0001f); // �� ���� ����ϰ� 0.0001�ʾ� ���
		}
	}

	private void End() {
		anim_window.SetBool("isOpen", false);
		txtSentence.text = string.Empty;
	}
}