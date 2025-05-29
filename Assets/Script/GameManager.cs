using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Sprite[] jellySpriteList;
    public string[] jellyNameList;
    public int[] jellyJelatineList;
    public int[] jellyGoldList;

    public Vector3[] PointList;
    public RuntimeAnimatorController[] LevelAc;

    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LevelAc[level - 1];
    }
}
