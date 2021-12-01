using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class MoveSphere : MonoBehaviour
{
    private Coroutine _coroutine;

    private bool _actionOneFinished = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.zero;
        
        _coroutine = StartCoroutine(AppearAfter(2));
    }

    private IEnumerator AppearAfter(float time){
        yield return new WaitForSeconds(time);
        transform.DOScale(Vector3.one, 1).SetEase(Ease.OutBack);
    }

    private IEnumerator WaitForActionOneFinished(){
        while(!_actionOneFinished) yield return null;
        StartActionTwo();
    }

    private void StartActionTwo()
    {
        throw new NotImplementedException();
    }

    void OnDestroy(){
        if(_coroutine != null){
            StopCoroutine(_coroutine);
        }
    }
}
