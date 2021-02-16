using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKillable
{
    void Kill();
}

public interface IDamageable<T>
{
    void Damage(T damageTaken);
}

public abstract class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    public void Kill()
    {

    }
    public abstract void Damage(float damageTaken);
}