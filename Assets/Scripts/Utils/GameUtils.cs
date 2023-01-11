using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;

public static class GameUtils
{
    //#if UNITY_EDITOR REMOVE O CÓDIGO EDITOR DE UM SCRIPT QUE NÃO É EDITOR PARA NÃO CAUSAR BUG NA COMPILAÇÃO DO JOGO.
#if UNITY_EDITOR
    [UnityEditor.MenuItem("Ebac/Test")]
    public static void Test()
    {
        Debug.Log("Teste");
    }

    //Cria botão de atalho no menu. % = CTRL, # = SHIFT, & = ALT, LEFT/R/UP/D = Arrow Keys, F1, F2... = F Keys, Home, End, PGUP, PGDN 
    [UnityEditor.MenuItem("Ebac/Test2 %g")]
    public static void Test2()
    {
        Debug.Log("Teste");
    }

#endif

    #region SCALE STUFF
    public static void Scale(this Transform t, float size = 1.2f)
    {
        t.localScale = Vector3.one * size;
    }

    public static void Scale(this GameObject t, float size = 1.2f)
    {
        t.transform.localScale = Vector3.one * size;
    }

    public static void ScaleVector(this Vector3 t, float size = 1.2f)
    {
        //t.localScale = Vector3.one * size;
    }
    #endregion


    #region RANDOM STUFF
    public static T GetRandom<T>(this T[] array)
    {
        if (array.Length == 0)
            return default(T);

        return array[Random.Range(0, array.Length)];
    }
    
    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    public static T GetRandomButNotSame<T>(this List<T> list, T unique)
    {
        if (list.Count == 1)
            return unique;

        int randomIndex = Random.Range(0, list.Count);
        return list[randomIndex];
    }
    #endregion
}

