using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string[] jellyNameList;
    public int[] jellyJelatineList;
    public int[] jellyGoldList;
    public int[] numGoldList;
    public int[] clickGoldList;

     public Sprite[] jellySpriteList;
    public Vector3[] PointList;
    public RuntimeAnimatorController[] LevelAc;

    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LevelAc[level - 1];
    }
}
