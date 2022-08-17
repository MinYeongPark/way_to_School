using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /* // �̱��� //
     * instance��� ������ static���� ������ �Ͽ� �ٸ� ������Ʈ ���� ��ũ��Ʈ������ instance�� �ҷ��� �� �ְ� �մϴ� 
     */
    public static GameManager instance = null;

    private void Awake()
    {
        if (instance == null) // instance�� null. ��, �ý��ۻ� �����ϰ� ���� ������
        {
            instance = this; // ���ڽ��� instance�� �־��ݴϴ�.
            DontDestroyOnLoad(gameObject); // OnLoad(���� �ε� �Ǿ�����) �ڽ��� �ı����� �ʰ� ����
        }
        else
        {
            if (instance != this) // instance�� ���� �ƴ϶�� �̹� instance�� �ϳ� �����ϰ� �ִٴ� �ǹ�
                Destroy(this.gameObject); // �� �̻� �����ϸ� �ȵǴ� ��ü�̴� ��� AWake�� �ڽ��� ����
        }
    }

    // [Scene6 ���൵ üũ]
    // �� ��Ҹ� ��� �����ߴ����� ���� �ʱ�ȭ�صΰ� �� ��Ҹ� �������� ��� true�� ������
    // �л�1,2
    public bool student1 = false;
    public bool student2 = false;
    
    // Locker ���
    public bool bullyMemo = false;
    public bool greenNote = false;
    public bool library_Spec = false;
    public bool postcard3 = false;

    // Desk ���
    public bool postcard2 = false;
}