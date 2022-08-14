using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
	public List<string> names;
	public List<Sprite> sprites_sujeong;
	public List<Sprite> sprites_other;
	public List<bool> open_sj;         // ���� â���� ������ �ι� �̹����� ��Ÿ������ ����
	public List<bool> open_other;      // ���� â���� �ٸ� �ι� �̹����� ��Ÿ������ ����
	
	[TextArea]
	public List<string> sentences;
}
