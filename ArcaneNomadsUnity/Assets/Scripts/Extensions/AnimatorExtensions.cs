using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimatorExtensions
{
    public static bool ParameterExists(this Animator animator, string name)
    {
        for (int i = 0; i < animator.parameterCount; i++)
            if(animator.parameters[i].name == name)
                return true;

        return false;
    }

    public static void SetFloatChecked(this Animator animator, string name, float value)
    {
        if(animator.ParameterExists(name))
            animator.SetFloat(name, value);
    }

    public static void SetFloatChecked(this Animator animator, string name, float value, float dampTime, float deltaTime)
    {
        if(animator.ParameterExists(name))
            animator.SetFloat(name, value, dampTime, deltaTime);
    }

    public static void SetBoolChecked(this Animator animator, string name, bool value)
    {
        if(animator.ParameterExists(name))
            animator.SetBool(name, value);
    }

    public static void SetIntChecked(this Animator animator, string name, int value)
    {
        if(animator.ParameterExists(name))
            animator.SetInteger(name, value);
    }

    public static void SetTriggerChecked(this Animator animator, string name)
    {
        if(animator.ParameterExists(name))
            animator.SetTrigger(name);
    }
}
