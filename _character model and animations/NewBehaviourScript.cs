using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("Dancing Twerk");
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            _animator.SetTrigger("Twist Dance");
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            _animator.SetTrigger("Silly Dancing");
        }
        else if(Input.GetKeyUp(KeyCode.LeftAlt))
        {
            _animator.SetTrigger("Flair");
        }
    }
}
