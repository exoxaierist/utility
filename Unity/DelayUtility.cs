using System;
using System.Collections;
using UnityEngine;

namespace Monotone.Utility
{
    public static class DelayUtility
    {
        public static Coroutine Delay(this MonoBehaviour mono, float delay, Action action, bool isRealTime = false)
        {
            if (!mono.enabled) return null;
            return mono.StartCoroutine(C_Delay(delay, action, isRealTime));
        }
        private static IEnumerator C_Delay(float delay, Action action, bool isRealTime = false)
        {
            //delay for a frame
            if (delay == 0) yield return null;
            else
            {
                if (isRealTime) yield return new WaitForSecondsRealtime(delay);
                else yield return new WaitForSeconds(delay);
            }
            action?.Invoke();
        }

        public static Coroutine Delay<T1>(this MonoBehaviour mono, float delay, Action<T1> action, T1 param1, bool isRealTime = false)
        {
            if (!mono.enabled) return null;
            return mono.StartCoroutine(C_Delay<T1>(delay, action, param1, isRealTime));
        }
        private static IEnumerator C_Delay<T1>(float delay, Action<T1> action, T1 param1, bool isRealTime = false)
        {
            //delay for a frame
            if (delay == 0) yield return null;
            else
            {
                if (isRealTime) yield return new WaitForSecondsRealtime(delay);
                else yield return new WaitForSeconds(delay);
            }
            action?.Invoke(param1);
        }

        public static Coroutine Delay<T1,T2>(this MonoBehaviour mono, float delay, Action<T1,T2> action, T1 param1, T2 param2, bool isRealTime = false)
        {
            if (!mono.enabled) return null;
            return mono.StartCoroutine(C_Delay<T1,T2>(delay, action, param1, param2, isRealTime));
        }
        private static IEnumerator C_Delay<T1,T2>(float delay, Action<T1,T2> action, T1 param1, T2 param2, bool isRealTime = false)
        {
            //delay for a frame
            if (delay == 0) yield return null;
            else
            {
                if (isRealTime) yield return new WaitForSecondsRealtime(delay);
                else yield return new WaitForSeconds(delay);
            }
            action?.Invoke(param1, param2);
        }

        public static Coroutine Delay<T1, T2, T3>(this MonoBehaviour mono, float delay, Action<T1, T2, T3> action, T1 param1, T2 param2, T3 param3, bool isRealTime = false)
        {
            if (!mono.enabled) return null;
            return mono.StartCoroutine(C_Delay<T1, T2, T3>(delay, action, param1, param2, param3, isRealTime));
        }
        private static IEnumerator C_Delay<T1, T2, T3>(float delay, Action<T1, T2, T3> action, T1 param1, T2 param2, T3 param3, bool isRealTime = false)
        {
            //delay for a frame
            if (delay == 0) yield return null;
            else
            {
                if (isRealTime) yield return new WaitForSecondsRealtime(delay);
                else yield return new WaitForSeconds(delay);
            }
            action?.Invoke(param1, param2, param3);
        }
    }
}
